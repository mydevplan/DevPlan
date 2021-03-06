using HProject.Web.Models;
using HProject.Data.Infrastructure;
using HProject.Data.Repositories;
using HProject.Entities;
// <copyright file="ProjectsControllerTest.cs">Copyright ©  2015</copyright>
using System;
using System.Net.Http;
using HProject.Web.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HProject.Web.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for ProjectsController</summary>
    [PexClass(typeof(ProjectsController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ProjectsControllerTest
    {
        /// <summary>Test stub for Get(HttpRequestMessage, String)</summary>
        [PexMethod]
        public HttpResponseMessage GetTest(
            [PexAssumeUnderTest]ProjectsController target,
            HttpRequestMessage request,
            string filter
        )
        {
            HttpResponseMessage result = target.Get(request, filter);
            return result;
            // TODO: add assertions to method ProjectsControllerTest.GetTest(ProjectsController, HttpRequestMessage, String)
        }

        /// <summary>Test stub for .ctor(IEntityBaseRepository`1&lt;Project&gt;, IEntityBaseRepository`1&lt;Error&gt;, IUnitOfWork)</summary>
        [PexMethod]
        public ProjectsController ConstructorTest(
            IEntityBaseRepository<Project> projectsRepository,
            IEntityBaseRepository<Error> _errorsRepository,
            IUnitOfWork _unitOfWork
        )
        {
            ProjectsController target
               = new ProjectsController(projectsRepository, _errorsRepository, _unitOfWork);
            return target;
            // TODO: add assertions to method ProjectsControllerTest.ConstructorTest(IEntityBaseRepository`1<Project>, IEntityBaseRepository`1<Error>, IUnitOfWork)
        }        

        /// <summary>Test stub for Get(HttpRequestMessage, Int32)</summary>
        [PexMethod]
        public HttpResponseMessage GetTest01(
            [PexAssumeUnderTest]ProjectsController target,
            HttpRequestMessage request,
            int id
        )
        {
            HttpResponseMessage result = target.Get(request, id);
            return result;
            // TODO: add assertions to method ProjectsControllerTest.GetTest01(ProjectsController, HttpRequestMessage, Int32)
        }

        /// <summary>Test stub for Register(HttpRequestMessage, ProjectViewModel)</summary>
        [PexMethod]
        public HttpResponseMessage RegisterTest(
            [PexAssumeUnderTest]ProjectsController target,
            HttpRequestMessage request,
            ProjectViewModel project
        )
        {
            HttpResponseMessage result = target.Register(request, project);
            return result;
            // TODO: add assertions to method ProjectsControllerTest.RegisterTest(ProjectsController, HttpRequestMessage, ProjectViewModel)
        }

        /// <summary>Test stub for Search(HttpRequestMessage, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;, String)</summary>
        [PexMethod]
        public HttpResponseMessage SearchTest(
            [PexAssumeUnderTest]ProjectsController target,
            HttpRequestMessage request,
            int? page,
            int? pageSize,
            string filter
        )
        {
            HttpResponseMessage result = target.Search(request, page, pageSize, filter);
            return result;
            // TODO: add assertions to method ProjectsControllerTest.SearchTest(ProjectsController, HttpRequestMessage, Nullable`1<Int32>, Nullable`1<Int32>, String)
        }

        /// <summary>Test stub for Update(HttpRequestMessage, ProjectViewModel)</summary>
        [PexMethod]
        public HttpResponseMessage UpdateTest(
            [PexAssumeUnderTest]ProjectsController target,
            HttpRequestMessage request,
            ProjectViewModel project
        )
        {
            HttpResponseMessage result = target.Update(request, project);
            return result;
            // TODO: add assertions to method ProjectsControllerTest.UpdateTest(ProjectsController, HttpRequestMessage, ProjectViewModel)
        }
    }
}
