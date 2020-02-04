/* 
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing CompteApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CompteApiTests
    {
        private CompteApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CompteApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CompteApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CompteApi
            //Assert.IsInstanceOfType(typeof(CompteApi), instance, "instance is a CompteApi");
        }

        /// <summary>
        /// Test DeleteCompteItem
        /// </summary>
        [Test]
        public void DeleteCompteItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteCompteItem(id);
            
        }
        /// <summary>
        /// Test GetCompteCollection
        /// </summary>
        [Test]
        public void GetCompteCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //var response = instance.GetCompteCollection(page);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test GetCompteItem
        /// </summary>
        [Test]
        public void GetCompteItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetCompteItem(id);
            //Assert.IsInstanceOf<ComponentsschemasComptejsonld> (response, "response is ComponentsschemasComptejsonld");
        }
        /// <summary>
        /// Test PatchCompteItem
        /// </summary>
        [Test]
        public void PatchCompteItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Compte body = null;
            //var response = instance.PatchCompteItem(id, body);
            //Assert.IsInstanceOf<ComponentsschemasComptejsonld> (response, "response is ComponentsschemasComptejsonld");
        }
        /// <summary>
        /// Test PostCompteCollection
        /// </summary>
        [Test]
        public void PostCompteCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Compte body = null;
            //var response = instance.PostCompteCollection(body);
            //Assert.IsInstanceOf<ComponentsschemasComptejsonld> (response, "response is ComponentsschemasComptejsonld");
        }
        /// <summary>
        /// Test PutCompteItem
        /// </summary>
        [Test]
        public void PutCompteItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Compte body = null;
            //var response = instance.PutCompteItem(id, body);
            //Assert.IsInstanceOf<ComponentsschemasComptejsonld> (response, "response is ComponentsschemasComptejsonld");
        }
    }

}
