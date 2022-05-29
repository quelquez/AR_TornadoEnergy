using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkController : MonoBehaviour
{
    public void openVK()
    {
        Application.OpenURL("https://vk.com/tornado_energy");
    }

    public void openYoutube()
    {
        Application.OpenURL("https://www.youtube.com/embed/gM-1SnXSCSY");
    }

    public void openSite()
    {
        Application.OpenURL("https://tornadoenergy.me");
    }
}
