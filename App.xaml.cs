﻿using PKHeX.Core;

namespace PKHeXMAUI;

public partial class App : Application
{
	public App()
	{
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt+QHFqUUdrXVNbdV5dVGpAd0N3RGlcdlR1fUUmHVdTRHRcQlliQH9Qd0FgW3ZecnU=;Mgo+DSMBPh8sVXJ1S0d+WFBPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9gSXpSf0RgWHtdcn1UQGE=;ORg4AjUWIQA/Gnt2VFhhQlVFfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hSn5Xd0xiWn5ac3ZcRWFd;MTc3OTMzNkAzMjMxMmUzMTJlMzQzMVdMeml4aCtKbVRnQmh6emt4S3ZtUGlFbGl2K3ZrakRFaXpoVlIzTHNCeVk9;MTc3OTMzN0AzMjMxMmUzMTJlMzQzMWlLb3JtQWVhSjhHYjZnRjlydlhCQld1ak5CbTdaU2xqenFyQXVhSVFwU3c9;NRAiBiAaIQQuGjN/V0d+XU9Ad1RDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31TckRqWHxfdHdWRmFcUA==;MTc3OTMzOUAzMjMxMmUzMTJlMzQzMVNrdE16clc2Q3hFd04vTE5iUXlHLzZ6enJoNGdla0dOTVJLZHcycjFOM0U9;MTc3OTM0MEAzMjMxMmUzMTJlMzQzMVJhcWlXUCsxMk0zd1BCZ2ZkT1hFRmlnYm1pZXN4WGdBaWV2dDdJRHduVEE9;Mgo+DSMBMAY9C3t2VFhhQlVFfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hSn5Xd0xiWn5ac3dURmBd;MTc3OTM0MkAzMjMxMmUzMTJlMzQzMURYUHpwc3FrbXA3RXRsSWY1MVBNOVVXc2prc2NaT3REeE9uazlPN0dHYTg9;MTc3OTM0M0AzMjMxMmUzMTJlMzQzMWtocWFXWFliRUlUc3RTc0d0cGxIeVd2eGNOd0toVjgwbkdBRlRJRThCc2s9;MTc3OTM0NEAzMjMxMmUzMTJlMzQzMVNrdE16clc2Q3hFd04vTE5iUXlHLzZ6enJoNGdla0dOTVJLZHcycjFOM0U9");
        InitializeComponent();

        var Version = Preferences.Default.Get("SaveFile", 50);
        if (PSettings.RememberLastSave)
            MainPage = new AppShell(SaveUtil.GetBlankSAV((GameVersion)Version, "PKHeX"));
        else
            MainPage = new AppShell(SaveUtil.GetBlankSAV((GameVersion)50, "PKHeX"));
    }
}
