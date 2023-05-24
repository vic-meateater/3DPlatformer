using YandexMobileAds;
using YandexMobileAds.Base;
using UnityEngine;

namespace Bario
{
    public class YandexBanner : MonoBehaviour
    {
        private Banner banner;

        private void RequestBanner()
        {
            string adUnitId = "demo-banner-yandex";

            // Set flexible banner maximum width and height
            AdSize bannerMaxSize = AdSize.FlexibleSize(GetScreenWidthDp(), 100);
            // Or set sticky banner maximum width
            //AdSize bannerMaxSize = AdSize.StickySize(GetScreenWidthDp());

            banner = new Banner(adUnitId, bannerMaxSize, AdPosition.BottomCenter);
        }

        // Example how to get screen width for request
        private int GetScreenWidthDp()
        {
            int screenWidth = (int)Screen.safeArea.width;
            return ScreenUtils.ConvertPixelsToDp(screenWidth);
        }
    }
}
