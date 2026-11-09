using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ViewTask.Controllers;
using Xunit;

namespace ViewTask.Tests;

public class TasksControllerTests
{
    [Fact]
    public void ShoppingList_ReturnsExpectedItems()
    {
        var result = new TasksController().ShoppingList();

        var view = Assert.IsType<ViewResult>(result);
        var items = Assert.IsType<Dictionary<string, int>>(view.Model);
        Assert.Equal(5, items.Count);
        Assert.Equal(2, items["Milk"]);
    }

    [Fact]
    public void SuperMarkets_ReturnsFiveMarkets()
    {
        var result = new TasksController().SuperMarkets();

        var view = Assert.IsType<ViewResult>(result);
        var markets = Assert.IsType<List<string>>(view.ViewData["Supermarkets"]);
        Assert.Equal(5, markets.Count);
        Assert.Contains("Metro", markets);
    }

    [Fact]
    public void ShoppingCartPost_ReturnsConfirmationWithSubmittedDetails()
    {
        var result = new TasksController().ShoppingCart(
            "Alex", "Main Street 1", "ATB", "2025-01-02", new[] { "Milk" });

        var view = Assert.IsType<ViewResult>(result);
        Assert.Equal("ShoppingCartResult", view.ViewName);
        Assert.Contains("Alex", view.ViewData["Message"]?.ToString());
        Assert.Contains("ATB", view.ViewData["Message"]?.ToString());
    }
}
