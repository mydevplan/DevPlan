using HProject.Web.Models;
using System.Net.Http;
using HProject.Data.Infrastructure;
using HProject.Data.Repositories;
using HProject.Entities;
using HProject.Services;
// <copyright file="AccountControllerTests.cs">Copyright ©  2015</copyright>

using System;
using HProject.Web.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HProject.Web.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for AccountController</summary>
    [TestClass]
    [PexClass(typeof(AccountController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AccountControllerTests
    {

        /// <summary>Test stub for .ctor(IMembershipService, IEntityBaseRepository`1&lt;Error&gt;, IUnitOfWork)</summary>
        [PexMethod]
        public AccountController ConstructorTest(
            IMembershipService membershipService,
            IEntityBaseRepository<Error> _errorsRepository,
            IUnitOfWork _unitOfWork
        )
        {
            AccountController target = new AccountController(membershipService, _errorsRepository, _unitOfWork);
            return target;
            // TODO: add assertions to method AccountControllerTests.ConstructorTest(IMembershipService, IEntityBaseRepository`1<Error>, IUnitOfWork)
        }

        /// <summary>Test stub for Login(HttpRequestMessage, LoginViewModel)</summary>
        [PexMethod]
        public HttpResponseMessage LoginTest(
            [PexAssumeUnderTest]AccountController target,
            HttpRequestMessage request,
            LoginViewModel user
        )
        {
            HttpResponseMessage result = target.Login(request, user);
            return result;
            // TODO: add assertions to method AccountControllerTests.LoginTest(AccountController, HttpRequestMessage, LoginViewModel)
        }

        /// <summary>Test stub for Register(HttpRequestMessage, RegistrationViewModel)</summary>
        [PexMethod]
        public HttpResponseMessage RegisterTest(
            [PexAssumeUnderTest]AccountController target,
            HttpRequestMessage request,
            RegistrationViewModel user
        )
        {
            HttpResponseMessage result = target.Register(request, user);
            return result;
            // TODO: add assertions to method AccountControllerTests.RegisterTest(AccountController, HttpRequestMessage, RegistrationViewModel)
        }
    }
}
