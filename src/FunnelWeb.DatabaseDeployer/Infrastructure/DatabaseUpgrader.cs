﻿using System;
using System.Collections.Generic;
using FunnelWeb.DatabaseDeployer.Infrastructure.Execution;
using FunnelWeb.DatabaseDeployer.Infrastructure.ScriptProviders;
using FunnelWeb.DatabaseDeployer.Infrastructure.VersionTrackers;

namespace FunnelWeb.DatabaseDeployer.Infrastructure
{
    /// <summary>
    /// This class orchestrates the database upgrade process.
    /// </summary>
    public class DatabaseUpgrader
    {
        private readonly string connectionString;
        private readonly IScriptProvider scriptProvider;
        private readonly IVersionTracker versionTracker;
        private readonly IScriptExecutor scriptExecutor;

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseUpgrader"/> class.
        /// </summary>
        public DatabaseUpgrader(string connectionString, IScriptProvider scriptProvider, IVersionTracker versionTracker, IScriptExecutor scriptExecutor)
        {
            this.connectionString = connectionString;
            this.scriptExecutor = scriptExecutor;
            this.versionTracker = versionTracker;
            this.scriptProvider = scriptProvider;
        }

        /// <summary>
        /// Performs the database upgrade.
        /// </summary>
        public DatabaseUpgradeResult PerformUpgrade(ILog log)
        {
            var originalVersion = 0;
            var currentVersion = 0;
            var maximumVersion = 0;
            var scripts = new List<IScript>();
            try
            {
                log.WriteInformation("Beginning database upgrade. Connection string is: '{0}'", connectionString);

                originalVersion = versionTracker.RecallVersionNumber(connectionString, log);
                maximumVersion = scriptProvider.GetHighestScriptVersion();

                currentVersion = originalVersion;
                while (currentVersion < maximumVersion)
                {
                    currentVersion++;
                    log.WriteInformation("Upgrading to version: '{0}'", currentVersion);
                    using (log.Indent())
                    {
                        var script = scriptProvider.GetScript(currentVersion);
                        scriptExecutor.Execute(connectionString, script, log);
                        versionTracker.StoreUpgrade(connectionString, script, log);
                        scripts.Add(script);
                    }
                }
                log.WriteInformation("Upgrade successful");
                return new DatabaseUpgradeResult(scripts, originalVersion, currentVersion, true, null);
            }
            catch (Exception ex)
            {
                log.WriteError("Upgrade failed", ex);
                return new DatabaseUpgradeResult(scripts, originalVersion, currentVersion, false, ex);
            }
        }
    }
}