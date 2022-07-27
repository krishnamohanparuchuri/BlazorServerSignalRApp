using BlazorServerSignalRApp.Models;

namespace BlazorServerSignalRApp.Data
{
    public class ItemService
    {

        public List<Item> items = new()
        {
            new Item
            {
                Id=1,
                Price=26.66m,
                Name= "Painting"

            },
            new Item
            {
                Id=2,
                Price=27.66m,
                Name= "Electronics"

            },
            new Item
            {
                Id=3,
                Price=26.66m,
                Name= "Books"

            }
            ,
            new Item
            {
                Id=4,
                Price=16.26m,
                Name= "Movie tickets"

            }
        };

        public async Task<List<Item>> GetItems()
        {
            return items;
        }

        public void GetItem(int id, decimal newBid)
        {
            items.FirstOrDefault((i) => i.Id == id).Price = newBid;
        }
    }
}
    