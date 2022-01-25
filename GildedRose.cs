using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {





            for (var i = 0; i < Items.Count; i++)
            {

                bool ItemsSellInSmallerThanZero = Items[i].SellIn < 0;
                bool ItemsNameNotAgedBrite = Items[i].Name != "Aged Brie";
                bool ItemsQualityBiggerThanZero = Items[i].Quality > 0;
                bool ItemsNameNotSulfurasHandOfRanagros = Items[i].Name != "Sulfuras, Hand of Ragnaros";
                bool ItemQualitySmallerThanFifty = Items[i].Quality < 50;
                bool ItemsQualityGreaterThanZero = Items[i].Quality > 0;
                bool ItemsSellInSmallerThanEleven = Items[i].SellIn < 11;
                bool ItemsSellInSmallerThanSix = Items[i].SellIn < 6;


                void IfItemQualitySmallerThanFiftyThenIncreaseItemQualityByOne()
                {
                    if(ItemQualitySmallerThanFifty)
                        Items[i].Quality = Items[i].Quality + 1;
                }

                void IncreaseItemQualityByOne()
                {
                    Items[i].Quality = Items[i].Quality + 1;
                }

                void DecreaseItemQualityByOne()
                {
                    Items[i].Quality = Items[i].Quality - 1;
                }


                if (ItemsNameNotAgedBrite &&
                    ItemsQualityGreaterThanZero &&
                    ItemsNameNotSulfurasHandOfRanagros
                    && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {

                    DecreaseItemQualityByOne();

                }
                else
                {
                    IfItemQualitySmallerThanFiftyThenIncreaseItemQualityByOne();

                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (ItemQualitySmallerThanFifty && ItemsSellInSmallerThanEleven)
                            {

                            IncreaseItemQualityByOne();

                        }

                            if (ItemQualitySmallerThanFifty && ItemsSellInSmallerThanSix)
                            {

                            IncreaseItemQualityByOne();

                            }
                        }
                    }
                

                if (ItemsNameNotSulfurasHandOfRanagros)
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }



                if (ItemsSellInSmallerThanZero && ItemsNameNotAgedBrite)
                {
                    if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                    {

                        Items[i].Quality = (ItemsQualityBiggerThanZero && ItemsNameNotSulfurasHandOfRanagros) ? Items[i].Quality - 1 : Items[i].Quality - Items[i].Quality;

                    }
                    else
                    {
                        IfItemQualitySmallerThanFiftyThenIncreaseItemQualityByOne();
                    }


                    if (ItemsSellInSmallerThanZero && ItemsNameNotAgedBrite)
                    {

                        Items[i].Quality =
                            (ItemsQualityGreaterThanZero && ItemsNameNotSulfurasHandOfRanagros &&
                            ItemsNameNotSulfurasHandOfRanagros && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                            ? Items[i].Quality : Items[i].Quality - Items[i].Quality;
                    }
                    else
                    {
                        IfItemQualitySmallerThanFiftyThenIncreaseItemQualityByOne();
                    }
                }
            }
        }
    }



}




        




        

