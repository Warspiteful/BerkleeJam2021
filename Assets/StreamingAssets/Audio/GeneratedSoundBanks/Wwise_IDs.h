/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID GAMESTART = 4058101365U;
        static const AkUniqueID MENU_CLICK = 760777789U;
        static const AkUniqueID PLAY_GAMETRACK = 3229127073U;
        static const AkUniqueID PLAY_MENUMUSIC = 2570041344U;
        static const AkUniqueID PLAYER_TYPING = 210840004U;
        static const AkUniqueID PLAYER_TYPING_STOP = 2380210979U;
        static const AkUniqueID TEXT_RECEIVE = 1590073574U;
        static const AkUniqueID TEXT_SEND = 1182229445U;
    } // namespace EVENTS

    namespace SWITCHES
    {
        namespace ENDING
        {
            static const AkUniqueID GROUP = 3966194980U;

            namespace SWITCH
            {
                static const AkUniqueID BAD_ENDING = 2222736396U;
                static const AkUniqueID GOOD_ENDING = 589883976U;
                static const AkUniqueID NEUTRAL_ENDING = 3321531000U;
            } // namespace SWITCH
        } // namespace ENDING

    } // namespace SWITCHES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID MASTERVOLUME = 2918011349U;
        static const AkUniqueID MUSICVOLUME = 2346531308U;
        static const AkUniqueID SFXVOLUME = 988953028U;
    } // namespace GAME_PARAMETERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID MAIN = 3161908922U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID IN_GAME_SFX = 3856960887U;
        static const AkUniqueID MAINMENU_SFX = 2045198250U;
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
        static const AkUniqueID MUSIC = 3991942870U;
    } // namespace BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
