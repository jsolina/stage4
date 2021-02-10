using Domain.Contracts;
using Infrastracture.Contracts;
using Infrastracture.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using TodoAppAPI.Controllers;
using Xunit;

namespace TodoApp.Test
{
    public class TaskListTest
    {
        TaskListController _controller;
        ITaskListServices _services;
        ITaskList _repoServices;

        public TaskListTest()
        {
            _controller = new  TaskListController(_services);
            _services = new TaskListServices(_repoServices);
        }

        /*

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetAll() as OkObjectResult;
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }
        */


        /*
        [Theory]
        [InlineData(false)]
        public void ewww(bool expected)
        {
            Assert.True(expected == false);
        }
        */
    }
}
