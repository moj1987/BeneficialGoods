using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeneficialGoods.Utilities
{
    internal class SampleReportString
    {
        private static string sampleResponseFromShopify = @"{
   ""orders"":[
      {
         ""id"":3889284415651,
         ""admin_graphql_api_id"":""gid://shopify/Order/3889284415651"",
         ""app_id"":580111,
         ""browser_ip"":""99.254.228.54"",
         ""buyer_accepts_marketing"":false,
         ""cancel_reason"":null,
         ""cancelled_at"":null,
         ""cart_token"":""92ee3630103abc0b36a2634dcdcc1fd6"",
         ""checkout_id"":20807813136547,
         ""checkout_token"":""143ce338683e552bc9b54fc790571dcc"",
         ""client_details"":{
            ""accept_language"":""en-us"",
            ""browser_height"":891,
            ""browser_ip"":""99.254.228.54"",
            ""browser_width"":1424,
            ""session_hash"":null,
            ""user_agent"":""Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/11.1.2 Safari/605.1.15""
         },
         ""closed_at"":null,
         ""confirmed"":true,
         ""contact_email"":""dmyundt@icloud.com"",
         ""created_at"":""2021-06-23T11:33:25-04:00"",
         ""currency"":""CAD"",
         ""current_subtotal_price"":""105.00"",
         ""current_subtotal_price_set"":{
            ""shop_money"":{
               ""amount"":""105.00"",
               ""currency_code"":""CAD""
            },
            ""presentment_money"":{
    ""amount"":""105.00"",
               ""currency_code"":""CAD""
            }
         },
         ""current_total_discounts"":""0.00"",
         ""current_total_discounts_set"":{
    ""shop_money"":{
        ""amount"":""0.00"",
               ""currency_code"":""CAD""
            },
            ""presentment_money"":{
        ""amount"":""0.00"",
               ""currency_code"":""CAD""
            }
},
         ""current_total_duties_set"":null,
         ""current_total_price"":""105.00"",
         ""current_total_price_set"":{
    ""shop_money"":{
        ""amount"":""105.00"",
               ""currency_code"":""CAD""
            },
            ""presentment_money"":{
        ""amount"":""105.00"",
               ""currency_code"":""CAD""
            }
},
         ""current_total_tax"":""0.00"",
         ""current_total_tax_set"":{
    ""shop_money"":{
        ""amount"":""0.00"",
               ""currency_code"":""CAD""
            },
            ""presentment_money"":{
        ""amount"":""0.00"",
               ""currency_code"":""CAD""
            }
},
         ""customer_locale"":""en"",
         ""device_id"":null,
         ""discount_codes"":[

         ],
         ""email"":""dmyundt@icloud.com"",
         ""financial_status"":""paid"",
         ""fulfillment_status"":null,
         ""gateway"":""shopify_payments"",
         ""landing_site"":""/products/tree-campaign"",
         ""landing_site_ref"":null,
         ""location_id"":null,
         ""name"":""#1093"",
         ""note"":"""",
         ""note_attributes"":[

         ],
         ""number"":93,
         ""order_number"":1093,
         ""order_status_url"":""https://beneficialgoods.com/51278381219/orders/94f75d78f2a8c326564d664d21724091/authenticate?key=04084ba25c1f50aa167ba7c6fd6c7c8c"",
         ""original_total_duties_set"":null,
         ""payment_gateway_names"":[
            ""shopify_payments""
         ],
         ""phone"":null,
         ""presentment_currency"":""CAD"",
         ""processed_at"":""2021-06-23T11:33:24-04:00"",
         ""processing_method"":""direct"",
         ""reference"":null,
         ""referring_site"":"""",
         ""source_identifier"":null,
         ""source_name"":""web"",
         ""source_url"":null,
         ""subtotal_price"":""105.00"",
         ""subtotal_price_set"":{
    ""shop_money"":{
        ""amount"":""105.00"",
               ""currency_code"":""CAD""
            },
            ""presentment_money"":{
        ""amount"":""105.00"",
               ""currency_code"":""CAD""
            }
},
         ""tags"":"""",
         ""tax_lines"":[

         ],
         ""taxes_included"":false,
         ""test"":false,
         ""token"":""94f75d78f2a8c326564d664d21724091"",
         ""total_discounts"":""0.00"",
         ""total_discounts_set"":{
    ""shop_money"":{
        ""amount"":""0.00"",
               ""currency_code"":""CAD""
            },
            ""presentment_money"":{
        ""amount"":""0.00"",
               ""currency_code"":""CAD""
            }
},
         ""total_line_items_price"":""105.00"",
         ""total_line_items_price_set"":{
    ""shop_money"":{
        ""amount"":""105.00"",
               ""currency_code"":""CAD""
            },
            ""presentment_money"":{
        ""amount"":""105.00"",
               ""currency_code"":""CAD""
            }
},
         ""total_outstanding"":""0.00"",
         ""total_price"":""105.00"",
         ""total_price_set"":{
    ""shop_money"":{
        ""amount"":""105.00"",
               ""currency_code"":""CAD""
            },
            ""presentment_money"":{
        ""amount"":""105.00"",
               ""currency_code"":""CAD""
            }
},
         ""total_price_usd"":""85.29"",
         ""total_shipping_price_set"":{
    ""shop_money"":{
        ""amount"":""0.00"",
               ""currency_code"":""CAD""
            },
            ""presentment_money"":{
        ""amount"":""0.00"",
               ""currency_code"":""CAD""
            }
},
         ""total_tax"":""0.00"",
         ""total_tax_set"":{
    ""shop_money"":{
        ""amount"":""0.00"",
               ""currency_code"":""CAD""
            },
            ""presentment_money"":{
        ""amount"":""0.00"",
               ""currency_code"":""CAD""
            }
},
         ""total_tip_received"":""0.00"",
         ""total_weight"":0,
         ""updated_at"":""2021-06-23T11:33:28-04:00"",
         ""user_id"":null,
         ""billing_address"":{
    ""first_name"":""Dianne"",
            ""address1"":""3 Morison St."",
            ""phone"":""(519) 301-3461"",
            ""city"":""Stratford"",
            ""zip"":""N5A5K8"",
            ""province"":""Ontario"",
            ""country"":""Canada"",
            ""last_name"":""Yundt"",
            ""address2"":"""",
            ""company"":null,
            ""latitude"":43.3778821,
            ""longitude"":-80.96728569999999,
            ""name"":""Dianne Yundt"",
            ""country_code"":""CA"",
            ""province_code"":""ON""
         },
         ""customer"":{
    ""id"":5380326391971,
            ""email"":""dmyundt@icloud.com"",
            ""accepts_marketing"":true,
            ""created_at"":""2021-06-23T11:22:22-04:00"",
            ""updated_at"":""2021-06-23T11:33:25-04:00"",
            ""first_name"":""Dianne"",
            ""last_name"":""Yundt"",
            ""orders_count"":1,
            ""state"":""disabled"",
            ""total_spent"":""105.00"",
            ""last_order_id"":3889284415651,
            ""note"":null,
            ""verified_email"":true,
            ""multipass_identifier"":null,
            ""tax_exempt"":false,
            ""phone"":null,
            ""tags"":""newsletter"",
            ""last_order_name"":""#1093"",
            ""currency"":""CAD"",
            ""accepts_marketing_updated_at"":""2021-06-23T11:22:22-04:00"",
            ""marketing_opt_in_level"":""single_opt_in"",
            ""tax_exemptions"":[

            ],
            ""admin_graphql_api_id"":""gid://shopify/Customer/5380326391971"",
            ""default_address"":{
        ""id"":6559817302179,
               ""customer_id"":5380326391971,
               ""first_name"":""Dianne"",
               ""last_name"":""Yundt"",
               ""company"":null,
               ""address1"":""3 Morison St."",
               ""address2"":"""",
               ""city"":""Stratford"",
               ""province"":""Ontario"",
               ""country"":""Canada"",
               ""zip"":""N5A5K8"",
               ""phone"":""(519) 301-3461"",
               ""name"":""Dianne Yundt"",
               ""province_code"":""ON"",
               ""country_code"":""CA"",
               ""country_name"":""Canada"",
               ""default"":true
            }
},
         ""discount_applications"":[

         ],
         ""fulfillments"":[

         ],
         ""line_items"":[
            {
               ""id"":10062294614179,
               ""admin_graphql_api_id"":""gid://shopify/LineItem/10062294614179"",
               ""fulfillable_quantity"":7,
               ""fulfillment_service"":""manual"",
               ""fulfillment_status"":null,
               ""gift_card"":false,
               ""grams"":0,
               ""name"":""Tree Campaign"",
               ""origin_location"":{
                  ""id"":2659740647587,
                  ""country_code"":""CA"",
                  ""province_code"":""ON"",
                  ""name"":""Beneficial Goods"",
                  ""address1"":""356 Ontario Street"",
                  ""address2"":""Box 341"",
                  ""city"":""Stratford"",
                  ""zip"":""N5A 3H8""
               },
               ""price"":""15.00"",
               ""price_set"":{
    ""shop_money"":{
        ""amount"":""15.00"",
                     ""currency_code"":""CAD""
                  },
                  ""presentment_money"":{
        ""amount"":""15.00"",
                     ""currency_code"":""CAD""
                  }
},
               ""product_exists"":true,
               ""product_id"":7051160649891,
               ""properties"":[

               ],
               ""quantity"":7,
               ""requires_shipping"":false,
               ""sku"":"""",
               ""taxable"":true,
               ""title"":""Tree Campaign"",
               ""total_discount"":""0.00"",
               ""total_discount_set"":{
    ""shop_money"":{
        ""amount"":""0.00"",
                     ""currency_code"":""CAD""
                  },
                  ""presentment_money"":{
        ""amount"":""0.00"",
                     ""currency_code"":""CAD""
                  }
},
               ""variant_id"":40818701172899,
               ""variant_inventory_management"":""shopify"",
               ""variant_title"":"""",
               ""vendor"":""Beneficial Goods"",
               ""tax_lines"":[

               ],
               ""duties"":[

               ],
               ""discount_allocations"":[

               ]
            }
         ],
         ""payment_details"":{
    ""credit_card_bin"":""519123"",
            ""avs_result_code"":""Y"",
            ""cvv_result_code"":""M"",
            ""credit_card_number"":""•••• •••• •••• 2635"",
            ""credit_card_company"":""Mastercard""
         },
         ""refunds"":[

         ],
         ""shipping_lines"":[

         ]
      },
      {
    ""id"":3888384213155,
         ""admin_graphql_api_id"":""gid://shopify/Order/3888384213155"",
         ""app_id"":580111,
         ""browser_ip"":""68.69.142.225"",
         ""buyer_accepts_marketing"":false,
         ""cancel_reason"":null,
         ""cancelled_at"":null,
         ""cart_token"":""245c9deb703d1a0c4547cb0cbd8dd6a3"",
         ""checkout_id"":20803172597923,
         ""checkout_token"":""0460c88d06df2b7425f475619129baff"",
         ""client_details"":{
        ""accept_language"":""en-CA,en-GB;q=0.9,en-US;q=0.8,en;q=0.7"",
            ""browser_height"":937,
            ""browser_ip"":""68.69.142.225"",
            ""browser_width"":1903,
            ""session_hash"":null,
            ""user_agent"":""Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.114 Safari/537.36""
         },
         ""closed_at"":null,
         ""confirmed"":true,
         ""contact_email"":""bev@bevhepurn.com"",
         ""created_at"":""2021-06-22T22:17:48-04:00"",
         ""currency"":""CAD"",
         ""current_subtotal_price"":""60.00"",
         ""current_subtotal_price_set"":{
        ""shop_money"":{
            ""amount"":""60.00"",
               ""currency_code"":""CAD""
            },
            ""presentment_money"":{
            ""amount"":""60.00"",
               ""currency_code"":""CAD""
            }
    },
         ""current_total_discounts"":""0.00"",
         ""current_total_discounts_set"":{
        ""shop_money"":{
            ""amount"":""0.00"",
               ""currency_code"":""CAD""
            },
            ""presentment_money"":{
            ""amount"":""0.00"",
               ""currency_code"":""CAD""
            }
    },
         ""current_total_duties_set"":null,
         ""current_total_price"":""60.00"",
         ""current_total_price_set"":{
        ""shop_money"":{
            ""amount"":""60.00"",
               ""currency_code"":""CAD""
            },
            ""presentment_money"":{
            ""amount"":""60.00"",
               ""currency_code"":""CAD""
            }
    },
         ""current_total_tax"":""0.00"",
         ""current_total_tax_set"":{
        ""shop_money"":{
            ""amount"":""0.00"",
               ""currency_code"":""CAD""
            },
            ""presentment_money"":{
            ""amount"":""0.00"",
               ""currency_code"":""CAD""
            }
    },
         ""customer_locale"":""en"",
         ""device_id"":null,
         ""discount_codes"":[

         ],
         ""email"":""bev@bevhepurn.com"",
         ""financial_status"":""paid"",
         ""fulfillment_status"":null,
         ""gateway"":""shopify_payments"",
         ""landing_site"":""/products/tree-campaign"",
         ""landing_site_ref"":null,
         ""location_id"":null,
         ""name"":""#1092"",
         ""note"":""These trees are in support of Christy Bertrand and her amazing work ethic and giving attitude. Yours in Rotary, Bev Hepburn"",
         ""note_attributes"":[

         ],
         ""number"":92,
         ""order_number"":1092,
         ""order_status_url"":""https://beneficialgoods.com/51278381219/orders/078a22c056b0a67468418647fed508a7/authenticate?key=b432a7ec463d1781f1662770c8b2fd08"",
         ""original_total_duties_set"":null,
         ""payment_gateway_names"":[
            ""shopify_payments""
         ],
         ""phone"":null,
         ""presentment_currency"":""CAD"",
         ""processed_at"":""2021-06-22T22:17:47-04:00"",
         ""processing_method"":""direct"",
         ""reference"":null,
         ""referring_site"":"""",
         ""source_identifier"":null,
         ""source_name"":""web"",
         ""source_url"":null,
         ""subtotal_price"":""60.00"",
         ""subtotal_price_set"":{
        ""shop_money"":{
            ""amount"":""60.00"",
               ""currency_code"":""CAD""
            },
            ""presentment_money"":{
            ""amount"":""60.00"",
               ""currency_code"":""CAD""
            }
    },
         ""tags"":"""",
         ""tax_lines"":[

         ],
         ""taxes_included"":false,
         ""test"":false,
         ""token"":""078a22c056b0a67468418647fed508a7"",
         ""total_discounts"":""0.00"",
         ""total_discounts_set"":{
        ""shop_money"":{
            ""amount"":""0.00"",
               ""currency_code"":""CAD""
            },
            ""presentment_money"":{
            ""amount"":""0.00"",
               ""currency_code"":""CAD""
            }
    },
         ""total_line_items_price"":""60.00"",
         ""total_line_items_price_set"":{
        ""shop_money"":{
            ""amount"":""60.00"",
               ""currency_code"":""CAD""
            },
            ""presentment_money"":{
            ""amount"":""60.00"",
               ""currency_code"":""CAD""
            }
    },
         ""total_outstanding"":""0.00"",
         ""total_price"":""60.00"",
         ""total_price_set"":{
        ""shop_money"":{
            ""amount"":""60.00"",
               ""currency_code"":""CAD""
            },
            ""presentment_money"":{
            ""amount"":""60.00"",
               ""currency_code"":""CAD""
            }
    },
         ""total_price_usd"":""48.50"",
         ""total_shipping_price_set"":{
        ""shop_money"":{
            ""amount"":""0.00"",
               ""currency_code"":""CAD""
            },
            ""presentment_money"":{
            ""amount"":""0.00"",
               ""currency_code"":""CAD""
            }
    },
         ""total_tax"":""0.00"",
         ""total_tax_set"":{
        ""shop_money"":{
            ""amount"":""0.00"",
               ""currency_code"":""CAD""
            },
            ""presentment_money"":{
            ""amount"":""0.00"",
               ""currency_code"":""CAD""
            }
    },
         ""total_tip_received"":""0.00"",
         ""total_weight"":0,
         ""updated_at"":""2021-06-22T22:17:51-04:00"",
         ""user_id"":null,
         ""billing_address"":{
        ""first_name"":""Bev"",
            ""address1"":""34 Burritt Street "",
            ""phone"":""(519) 573-2610"",
            ""city"":""Stratford"",
            ""zip"":""N5A 4W7"",
            ""province"":""Ontario"",
            ""country"":""Canada"",
            ""last_name"":""Hepburn"",
            ""address2"":"""",
            ""company"":null,
            ""latitude"":43.3736293,
            ""longitude"":-80.95833069999999,
            ""name"":""Bev Hepburn"",
            ""country_code"":""CA"",
            ""province_code"":""ON""
         },
         ""customer"":{
        ""id"":5379342205091,
            ""email"":""bev@bevhepurn.com"",
            ""accepts_marketing"":false,
            ""created_at"":""2021-06-22T22:16:47-04:00"",
            ""updated_at"":""2021-06-22T22:17:48-04:00"",
            ""first_name"":""Bev"",
            ""last_name"":""Hepburn"",
            ""orders_count"":1,
            ""state"":""disabled"",
            ""total_spent"":""60.00"",
            ""last_order_id"":3888384213155,
            ""note"":null,
            ""verified_email"":true,
            ""multipass_identifier"":null,
            ""tax_exempt"":false,
            ""phone"":null,
            ""tags"":"""",
            ""last_order_name"":""#1092"",
            ""currency"":""CAD"",
            ""accepts_marketing_updated_at"":""2021-06-22T22:16:48-04:00"",
            ""marketing_opt_in_level"":null,
            ""tax_exemptions"":[

            ],
            ""admin_graphql_api_id"":""gid://shopify/Customer/5379342205091"",
            ""default_address"":{
            ""id"":6558789173411,
               ""customer_id"":5379342205091,
               ""first_name"":""Bev"",
               ""last_name"":""Hepburn"",
               ""company"":null,
               ""address1"":""34 Burritt Street "",
               ""address2"":"""",
               ""city"":""Stratford"",
               ""province"":""Ontario"",
               ""country"":""Canada"",
               ""zip"":""N5A 4W7"",
               ""phone"":""(519) 573-2610"",
               ""name"":""Bev Hepburn"",
               ""province_code"":""ON"",
               ""country_code"":""CA"",
               ""country_name"":""Canada"",
               ""default"":true
            }
    },
         ""discount_applications"":[

         ],
         ""fulfillments"":[

         ],
         ""line_items"":[
            {
        ""id"":10060667158691,
               ""admin_graphql_api_id"":""gid://shopify/LineItem/10060667158691"",
               ""fulfillable_quantity"":4,
               ""fulfillment_service"":""manual"",
               ""fulfillment_status"":null,
               ""gift_card"":false,
               ""grams"":0,
               ""name"":""Tree Campaign"",
               ""origin_location"":{
            ""id"":2659740647587,
                  ""country_code"":""CA"",
                  ""province_code"":""ON"",
                  ""name"":""Beneficial Goods"",
                  ""address1"":""356 Ontario Street"",
                  ""address2"":""Box 341"",
                  ""city"":""Stratford"",
                  ""zip"":""N5A 3H8""
               },
               ""price"":""15.00"",
               ""price_set"":{
            ""shop_money"":{
                ""amount"":""15.00"",
                     ""currency_code"":""CAD""
                  },
                  ""presentment_money"":{
                ""amount"":""15.00"",
                     ""currency_code"":""CAD""
                  }
        },
               ""product_exists"":true,
               ""product_id"":7051160649891,
               ""properties"":[

               ],
               ""quantity"":4,
               ""requires_shipping"":false,
               ""sku"":"""",
               ""taxable"":true,
               ""title"":""Tree Campaign"",
               ""total_discount"":""0.00"",
               ""total_discount_set"":{
            ""shop_money"":{
                ""amount"":""0.00"",
                     ""currency_code"":""CAD""
                  },
                  ""presentment_money"":{
                ""amount"":""0.00"",
                     ""currency_code"":""CAD""
                  }
        },
               ""variant_id"":40818701172899,
               ""variant_inventory_management"":""shopify"",
               ""variant_title"":"""",
               ""vendor"":""Beneficial Goods"",
               ""tax_lines"":[

               ],
               ""duties"":[

               ],
               ""discount_allocations"":[

               ]
            }
         ],
         ""payment_details"":{
        ""credit_card_bin"":""453826"",
            ""avs_result_code"":""Y"",
            ""cvv_result_code"":""M"",
            ""credit_card_number"":""•••• •••• •••• 7023"",
            ""credit_card_company"":""Visa""
         },
         ""refunds"":[

         ],
         ""shipping_lines"":[

         ]
      }
 ]
}";

        public static string GetSampleData()
        {
            return sampleResponseFromShopify;
        }
    }
}