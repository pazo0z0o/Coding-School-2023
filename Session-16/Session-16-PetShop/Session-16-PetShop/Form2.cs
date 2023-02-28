 /* private void grv_TransactionLine_CellValueChanged(object sender, DataGridViewCellEventArgs e)
         {
             if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && grv_TransactionLine.Columns[e.ColumnIndex].Name == "ItemID")
             {
                 var currentItem = (TransactionLineListDTO)bsTransLine.Current;
                 var fuelItems = _itemList.Where(i => i.ItemType == ItemType.Fuel).ToList();
                 if (fuelItems.Any(fi => fi.ID == currentItem.ItemID))
                 {
                     MessageBox.Show("You cannot select an item of type fuel.", "Error");
                     bsTransLine.ResetCurrentItem();
                 }
             }
         }*/

        /* private void grv_TransactionLine_RowValidated(object sender, DataGridViewCellEventArgs e)
         {
             if (e.RowIndex >= 0)
             {
                 var currentItem = (TransactionLineListDTO)bsTransLine.List[e.RowIndex];
                 var fuelItems = _itemList.Where(i => i.ItemType == ItemType.Fuel).ToList();
                 if (fuelItems.Any(fi => fi.ID == currentItem.ItemID))
                 {
                     MessageBox.Show("You cannot select an item of type fuel.", "Error");
                    // e.Cancel = true;
                 }
             }
         }*/

        /* private void grv_TransactionLine_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
         {

             if (e.RowIndex >= 0)
             {
                 var currentItem = (TransactionLineListDTO)bsTransLine.List[e.RowIndex];
                 var fuelItems = _itemList.Where(i => i.ItemType == ItemType.Fuel).ToList();
                 if (fuelItems.Any(fi => fi.ID == currentItem.ItemID))
                 {
                     MessageBox.Show("You cannot select an item of type fuel.", "Error");
                      e.Cancel = true;
                 }
             }
         }*/