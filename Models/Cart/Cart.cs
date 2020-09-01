﻿
using System.Collections.Generic;
using System.Linq;
namespace MusicHub.Models.Cart
{
    public class Cart
    {
        private List<CartLine> _lineCollection= new List<CartLine>();

        //public void AddItems(int catalogItemId ,decimal unitPrice, int quantity = 1)
        //{
        //    if (!_Items.Any(i => i.CatalogItemId == catalogItemId))
        //    {
        //        _Items.Add(new CartItem()
        //        {
        //            CatalogItemId = catalogItemId,
        //            Quantity = quantity,
        //            UnitPrice = unitPrice
        //        });
        //        return;
        //    }

        //    var existingItem = _Items.FirstOrDefault(i => i.CatalogItemId == catalogItemId);
        //    existingItem.Quantity += quantity;

        //}

        public virtual void AddItems(Album album, int quantity)
        {
            CartLine line = _lineCollection.Where(a => a.Album.Id == album.Id).FirstOrDefault();

            if (line == null)
            {
                _lineCollection.Add(new CartLine
                {
                    Album = album,
                    Quantity = quantity
                });
            } else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Album album)
        {
            _lineCollection.RemoveAll(lc => lc.Album.Id == album.Id);
        }

        public virtual decimal ComputeTotalValue()
        {
            return _lineCollection.Sum(lc => lc.Album.Price * lc.Quantity);
        }

        public virtual void Clear() => _lineCollection.Clear();
        public IEnumerable<CartLine> Lines => _lineCollection;


        public class CartLine
        {
            public int CartLineId { get; set; }
            public Album Album { get; set; }
            public int Quantity { get; set; }
        }
    }
}
