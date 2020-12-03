﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient22.Models
{
	public class Sales
	{
		public int id { get; set; }
		public int users_id { get; set; }
		public int products_id { get; set; }
		public bool isBid { get; set; }
		public string description { get; set; }
		public int currentPrice { get; set; }
		public int highestBidder_id { get; set; }
		public TimeSpan timeRemaining { get; set; }
		public bool isActive { get; set; }

		public Sales()
        {
        }
		public Sales(int id_, int users_id_, int products_id_, bool isBid_, string description_, 
			int currentPrice_, int highestBidder_id_, TimeSpan timeRemaining_, bool isActive_)
		{
			this.id = id_;
			this.users_id = users_id_;
			this.products_id = products_id_;
			this.isBid = isBid_;
			this.description = description_;
			this.currentPrice = currentPrice_;
			this.highestBidder_id = highestBidder_id_;
			this.timeRemaining = timeRemaining_;
			this.isActive = isActive_;
		}
	}
}