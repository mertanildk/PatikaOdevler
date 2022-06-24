using System;
using System.Collections.Generic;

namespace ToDo
{
    public class ToDo
    {
        private List<CardModel> Card;

        public ToDo()
        {
            Card = new List<CardModel>();
        }

        public List<CardModel> Liste()
        {
            return Card;
        }

        public void Add(string baslik, string icerik, string kartsahibi, string buyukluk)
        {
            CardModel cardModel = new CardModel();
            cardModel.Baslik1 = baslik;
            cardModel.Icerik1 = icerik;
            cardModel.KartSahibi1 = kartsahibi;
            cardModel.Buyukluk1 = buyukluk;
            Card.Add(cardModel);
        }

        public void Delete(CardModel cardModel)
        {
            Card.Remove(cardModel);
        }

        public List<CardModel> Find(string baslik, string icerik, string kartsahibi, string buyukluk)
        {
            List<CardModel> result = new List<CardModel>();

            foreach (var item in Card)
            {
                if (item.Baslik1 == baslik || item.Icerik1 == icerik || item.KartSahibi1 == kartsahibi || item.Buyukluk1 == buyukluk)
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}