﻿using MYOB.AccountRight.SDK.Contracts.Version2.Inventory;

namespace MYOB.AccountRight.SDK.Contracts.Version2.Purchase
{
    /// <summary>
    /// Describe the Purchase/Bill/Item's Lines
    /// </summary>
    public class ItemBillLine: BillLine
    {
        /// <summary>
        /// The quantity of goods shipped.
        /// </summary>
        public decimal BillQuantity { get; set; }

        /// <summary>
        /// The quantity of goods received.
        /// </summary>
        public decimal ReceivedQuantity { get; set; }

        /// <summary>
        /// The quantity of goods to back order
        /// <remarks>To be implemented when Purchase Order functionality is available.</remarks>
        /// </summary>
        public decimal BackorderQuantity { get; set; }

        /// <summary>
        /// Unit price assigned to the item.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Discount rate applicable to the line of the purchase bill.
        /// </summary>
        public decimal DiscountPercent { get; set; }

        /// <summary>
        /// Item of the purchase item bill line
        /// </summary>
        public ItemLink Item { get; set; }
    }
}
