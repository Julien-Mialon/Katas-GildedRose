﻿using System.Collections.Generic;
using Xunit;

namespace GildedRose.Tests
{
    public class GildedRoseTest
    {
        [Fact]
        public void Foo()
        {
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.Equal("fixme", items[0].Name);
        }
    }
}