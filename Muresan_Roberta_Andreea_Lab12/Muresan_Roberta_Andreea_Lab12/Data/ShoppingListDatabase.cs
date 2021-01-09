using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Muresan_Roberta_Andreea_Lab12.Models;

namespace Muresan_Roberta_Andreea_Lab12.Data
{
    class ShoppingListDatabase
    {
        IRestService restService;
        public ShoppingListDatabase(IRestService service)
        {
            restService = service;
        }
        public Task<List<ShopList>> GetShopListsAsync()
        {
            return restService.RefreshDataAsync();
        }

        public Task SaveShopListAsync(ShopList item, bool isNewItem = true)
        {
            return restService.SaveShopListAsync(item, isNewItem);
        }
        public Task DeleteShopListAsync(ShopList item)
        {
            return restService.DeleteShopListAsync(item.ID);
        }

    }
} 
    
