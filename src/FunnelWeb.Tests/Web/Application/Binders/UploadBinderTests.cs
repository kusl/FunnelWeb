﻿using System.Web;
using System.Web.Mvc;
using FunnelWeb.Tests.Helpers;
using FunnelWeb.Web.Application;
using FunnelWeb.Web.Application.Mvc.Binders;
using NSubstitute;
using NUnit.Framework;

namespace FunnelWeb.Tests.Web.Application.Binders
{
    public class UploadBinderTests
    {
        public class Posted_files_should_turn_into_Upload_objects : Specification<ControllerContext>
        {
            public override ControllerContext Given()
            {
                var file = Substitute.For<HttpPostedFileBase>();
                file.FileName.Returns("file1.png");

                var httpFileCollection = Substitute.For<HttpFileCollectionBase>();
                httpFileCollection.Get(Arg.Is<string>("file1")).Returns(file);
                
                var httpRequest = Substitute.For<HttpRequestBase>();
                httpRequest.Files.Returns(httpFileCollection);
                
                var httpContext = Substitute.For<HttpContextBase>();
                httpContext.Request.Returns(httpRequest);
                
                var controller = Substitute.For<ControllerContext>();
                controller.HttpContext.Returns(httpContext);
                
                return controller;
            }

            public override void When()
            {
                Result = (Upload)new UploadBinder().BindModel(Subject,
                    new ModelBindingContext
                    {
                        ModelName = "file1"
                    });
            }

            protected Upload Result { get; set; }

            [Then]
            public void ShouldCreateUpload()
            {
                Assert.IsNotNull(Result);
                Assert.AreEqual("file1.png", Result.FileName);
            }
        }
    }
}
