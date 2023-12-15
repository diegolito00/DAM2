using NUnit.Framework;
using System.Collections.Generic;

namespace csharp.Tests
{
    [TestFixture]
    public class GildedRoseTests
    {
        [Test]
        public void UpdateNormal()
        {
            IList<Item> items = new List<Item>
            {
                new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 }
            };

            GildedRose gildedRose = new GildedRose(items);

            gildedRose.UpdateQuality();

            Assert.AreEqual(9, items[0].SellIn);
            Assert.AreEqual(19, items[0].Quality);
        }

        [Test]
        public void UpdateConjured()
        {
            IList<Item> items = new List<Item>
            {
                new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 30 },
                new Item { Name = "Conjured Mana Cake", SellIn = -2, Quality = 30 }
            };

            GildedRose gildedRose = new GildedRose(items);

            gildedRose.UpdateQuality();

            Assert.AreEqual(2, items[0].SellIn);
            Assert.AreEqual(28, items[0].Quality);
            Assert.AreEqual(-3, items[1].SellIn);
            Assert.AreEqual(26, items[1].Quality);
        }

        [Test]
        public void UpdateCheese() 
        {
            IList<Item> items = new List<Item>
            {
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                new Item { Name = "Aged Brie", SellIn = -2, Quality = 0 }
            };

            GildedRose gildedRose = new GildedRose(items);

            gildedRose.UpdateQuality();

            Assert.AreEqual(1, items[0].SellIn);
            Assert.AreEqual(1, items[0].Quality);
            Assert.AreEqual(-3, items[1].SellIn);
            Assert.AreEqual(2, items[1].Quality);
        }

        [Test]
        public void UpdateTicket() 
        {
            IList<Item> items = new List<Item>
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = 20 }
            };

            GildedRose gildedRose = new GildedRose(items);

            gildedRose.UpdateQuality();

            Assert.AreEqual(14, items[0].SellIn);
            Assert.AreEqual(21, items[0].Quality);
            Assert.AreEqual(9, items[1].SellIn);
            Assert.AreEqual(22, items[1].Quality);
            Assert.AreEqual(4, items[2].SellIn);
            Assert.AreEqual(23, items[2].Quality);
            Assert.AreEqual(-2, items[3].SellIn);
            Assert.AreEqual(0, items[3].Quality);
        }

        [Test]
        public void UpdateSulfuras()
        {
            IList<Item> items = new List<Item>
            {
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 15, Quality = 80 }
                
            };

            GildedRose gildedRose = new GildedRose(items);

            gildedRose.UpdateQuality();

            Assert.AreEqual(15, items[0].SellIn);
            Assert.AreEqual(80, items[0].Quality);
        }
    }
}
