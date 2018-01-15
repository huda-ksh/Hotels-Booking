using HotelsBooking.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Linq;

namespace HotelsBooking.Controllers
{
    public class HotelController : Controller
    {
        RootObject rootObject = new RootObject();

        [HttpGet]
        public ActionResult Index()
        {

            Uri uri = new Uri("https://offersvc.expedia.com/offers/v2/getOffers?scenario=deal-finder&page=foo&uid=foo&productType=Hotel");

            var json = new WebClient().DownloadString(uri);

            rootObject = JsonConvert.DeserializeObject<RootObject>(json);

            List<HotelModel> lstHotels = new List<HotelModel>();

            lstHotels = rootObject.offers.Hotel;
            HotelViewModel hotelVM = new HotelViewModel();
            hotelVM.HotelsList = lstHotels;
            hotelVM.SelectedCountry = string.Empty;
            return View(hotelVM);

        }

        [HttpPost]
        public ActionResult Index(HotelViewModel hotelVm)
        {
            Uri uri = new Uri("https://offersvc.expedia.com/offers/v2/getOffers?scenario=deal-finder&page=foo&uid=foo&productType=Hotel");
            
            var json = new WebClient().DownloadString(uri);

            rootObject = JsonConvert.DeserializeObject<RootObject>(json);


            List<HotelModel> lstHotels = new List<HotelModel>();

            lstHotels = rootObject.offers.Hotel;
            if (!string.IsNullOrEmpty(hotelVm.SelectedCountry) && !string.IsNullOrEmpty(hotelVm.hdnCity))
            {

                lstHotels = lstHotels.Where(x => x.destination.shortName.ToLower() == hotelVm.hdnCity.ToLower()).ToList();

            }



            if (hotelVm.DateFrom.HasValue)
            {
                lstHotels = lstHotels.Where(x => new DateTime(x.offerDateRange.travelStartDate[0], x.offerDateRange.travelStartDate[1], x.offerDateRange.travelStartDate[2]) >= Convert.ToDateTime(hotelVm.DateFrom)).ToList();
            }
            if (hotelVm.DateTo.HasValue)
            {
                lstHotels = lstHotels.Where(x => new DateTime(x.offerDateRange.travelEndDate[0], x.offerDateRange.travelEndDate[1], x.offerDateRange.travelEndDate[2]) <= Convert.ToDateTime(hotelVm.DateTo)).ToList();
            }
            if (hotelVm.LengthOfStay.HasValue)
            {
                lstHotels = lstHotels.Where(x => x.offerDateRange.lengthOfStay ==hotelVm.LengthOfStay).ToList();
            }
            if (hotelVm.MinStarRating.HasValue)
            {
                lstHotels = lstHotels.Where(x =>Convert.ToDecimal(x.hotelInfo.hotelStarRating) >= hotelVm.MinStarRating.Value).ToList();
            }
            if (hotelVm.MaxStarRating.HasValue)
            {
                lstHotels = lstHotels.Where(x => Convert.ToDecimal(x.hotelInfo.hotelStarRating) <= hotelVm.MaxStarRating).ToList();
            }
            if (hotelVm.MinTotalRate.HasValue)
            {
                lstHotels = lstHotels.Where(x => Convert.ToInt32(x.hotelInfo.hotelReviewTotal) >= hotelVm.MinTotalRate.Value).ToList();
            }
            if (hotelVm.MaxTotalRate.HasValue)
            {
                lstHotels = lstHotels.Where(x => Convert.ToInt32(x.hotelInfo.hotelReviewTotal) <= hotelVm.MaxTotalRate).ToList();
            }
            if (hotelVm.MinGuestRating.HasValue)
            {
                lstHotels = lstHotels.Where(x => Convert.ToDecimal(x.hotelInfo.hotelGuestReviewRating) >= hotelVm.MinGuestRating.Value).ToList();
            }
            if (hotelVm.MaxGuestRating.HasValue)
            {
                lstHotels = lstHotels.Where(x => Convert.ToDecimal(x.hotelInfo.hotelGuestReviewRating) <= hotelVm.MaxGuestRating).ToList();
            }
            hotelVm.HotelsList = lstHotels;
            return View(hotelVm);

        }
    }
}