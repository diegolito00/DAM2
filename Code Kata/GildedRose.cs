using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;

        public GildedRose(IList<Item> items)
        {
            this.Items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                UpdateQuality(item);
                UpdateSellIn(item);
            }
        }

        private void UpdateQuality(Item item)
        {
            if (item.Name != "Aged Brie" &&
                item.Name != "Backstage passes to a TAFKAL80ETC concert" &&
                item.Name != "Sulfuras, Hand of Ragnaros")
            {
                DecreaseQuality(item);
            }
            else
            {
                IncreaseQuality(item);

                if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (item.SellIn < 11)
                    {
                        IncreaseQuality(item);
                    }

                    if (item.SellIn < 6)
                    {
                        IncreaseQuality(item);
                    }
                }
            }
            if (item.SellIn < 0)
            {
                if (item.Name == "Aged Brie")
                {
                    IncreaseQuality(item);
                }
                else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    item.Quality = 0;
                }
                else
                {
                    DecreaseQuality(item);
                }
            }
        }

                

        private void DecreaseQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality--;
                if (item.Name.Contains("Conjured"))
                {
                    item.Quality--;
                }

            }
            
        }

        private void IncreaseQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality++;
            }
        }

        private void UpdateSellIn(Item item)
        {
            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.SellIn--;
            }
        }
    }
}