# NfcTile
Provides a Quick Settings tile on Android to show whether NFC is currently enabled on the device.

It also allows the user to quickly enable or disable NFC by tapping it.

... sort of.

Two caveats:
* It's not possible to programmatically turn NFC on or off (nor should it be). This tile just gives the user a shortcut to the settings page.
* Well, sort of again. The built-in Intent for accessing the NFC Settings page apparently points to the Connections Preferences page, not NFC. So it requires one more annoying tap to get there. Oh well.


![Tile Screenshot](/screenshots/tile.png?raw=true "NFC Tile")