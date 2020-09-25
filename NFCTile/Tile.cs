using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Service.QuickSettings;
using Android.Views;
using Android.Widget;

namespace NFCTile
{
    [Service(Name = "com.galagidae.NFCTile",
             Permission = Android.Manifest.Permission.BindQuickSettingsTile,
             Label = "NFC",
             Icon = "@drawable/ic_nfc_tile")]
    [IntentFilter(new[] { ActionQsTile })]
    class Tile : TileService
    {
        public override void OnTileAdded()
        {
            base.OnTileAdded();
        }

        public override void OnStartListening()
        {
            base.OnStartListening();
        }

        public override void OnStopListening()
        {
            base.OnStopListening();
        }

        public override void OnTileRemoved()
        {
            base.OnTileRemoved();
        }
    }
}