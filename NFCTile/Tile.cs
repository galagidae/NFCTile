using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Nfc;
using Android.OS;
using Android.Provider;
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

            var adapter = NfcAdapter.GetDefaultAdapter(this);

            if (adapter != null && adapter.IsEnabled)
                QsTile.State = TileState.Active;
            else
                QsTile.State = TileState.Inactive;

            QsTile.UpdateTile();
        }

        public override void OnStopListening()
        {
            base.OnStopListening();
        }

        public override void OnTileRemoved()
        {
            base.OnTileRemoved();
        }

        public override void OnClick()
        {
            base.OnClick();
            
            var intent = new Intent(Settings.ActionNfcSettings); // As good as it gets
            intent.AddFlags(ActivityFlags.NewTask | ActivityFlags.ClearTop);
            StartActivityAndCollapse(intent);
        }
    }
}