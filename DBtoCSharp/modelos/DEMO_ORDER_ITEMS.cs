
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DEMO_ORDER_ITEMS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int ORDER_ITEM_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ORDER_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PRODUCT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UNIT_PRICE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QUANTITY { get; set; }

        [NotMapped]
        public string Trigger_DEMO_ORDER_ITEMS_GET_PRICE { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  l_list_price number;\nbegin\n-- First, we need to get the current list price of the order line item\nselect list_price into l_list_price from demo_product_info\n  where product_id = :new.product_id;\n\n-- Once we have the correct price, we will update the order line with the correct price\n:new.unit_price := l_list_price;\n\nend;"}`;
    
        [NotMapped]
        public string Trigger_UPDATE_ORDER_TOTAL { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"begin\n\n-- Update the Order Total when any order item is changed\n\nupdate demo_orders set order_total =\n  (select sum(unit_price*quantity) from demo_order_items\n    where demo_order_items.order_id = demo_orders.order_id);\nend;"}`;
    
        [NotMapped]
        public string Trigger_INSERT_DEMO_ORDER_ITEMS { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin\ndeclare\n  order_item_id number;\nbegin\nselect demo_order_items_seq.nextval into order_item_id from dual;\n:new.ORDER_ITEM_ID := order_item_id;\nend;\nend;"}`;
    
    }
}
