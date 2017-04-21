﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MarvelData
{
    [StructLayout(LayoutKind.Sequential)]
    public struct StatusChunk
    {
        public int index;
        public StatusFlags statusflags;
        public int totalhealth;
        public float unk0C;
        public float damagegiven;
        public float damagetaken;
        public float speedself;
        public float speedreceived;
        public float unk20;
        public float comboweight;
        public int unk28;
        public float unk2C;
        public float CameraSizeX;
        public float partner2offsetIntro;
        public float partner1offsetIntro;
        public int unk3C;
        public int unk40;
        public int airActions;
        public float unk48;
        public float dashAccelAfter;
        public float unk50;
        public float dashTraction;
        public int unk58;
        public float unk5C;
        public float unk60;
        public float flightClearance;
        public float unk68;
        public int unk6C; // 0x6c
        public int unk70;
        public int unk74;
        public int unk78;
        public int unk7C;
        public int unk80;
        public int unk84;
        public int unk88;
        public int unk8C;
        public int unk90;
        public int unk94;
        public float minDamageScalingNormals;
        public float minScalingSpecials;
        public float minScalingHypers;
        public int unkA4;
        public int unkA8;
        public int unkAC;
        public int unkB0;
        public int unkB4;
        public int unkB8;
        public int unkBC;
        public int unkC0;
        public int unkC4;
        public int unkC8;
        public int unkCC;
        public int unkD0;
        public int unkD4;
        public float XF1Damage;
        public float XF1Speed;
        public float XF1Duration;
        public int unkE4;
        public int unkE8;
        public int unkEC;
        public int unkF0;
        public float unkF4;
        public float unkF8;
        public int unkFC;
        public int unk100;
        public int unk104;
        public float XF2Damage;
        public float XF2Speed;
        public float XF2Duration;
        public int unk114;
        public int unk118;
        public int unk11C;
        public int unk120;
        public float unk124;
        public float unk128;
        public int unk12C;
        public int unk130;
        public int unk134;
        public float XF3Damage;
        public float XF3Speed;
        public float XF3Duration;
        public int unk144;
        public int unk148;
        public int unk150;
        public float unk154;
        public float unk158;
        public int unk15C;
        public int unk160;
        public int unk164;
        public int unk168;
        public int unk16C;
        public int unk170;
        public int unk174;
        public int unk178;
        public int unk17C;
        public int unk180;
        public int unk184;
        public int unk188;
        public int unk18C;
        public int unk190;
        public int unk194;
        public int unk198;
        public int unk19C;
        public int unk1A0;
        public int unk1A4;
        public int unk1A8;
        public int unk1AC;
        public int unk1B0;
        public int unk1B4;
        public int unk1B8;
        public int unk1BC;
        public int unk1C0;
        public int unk1C4;
        public int unk1C8;
        public int unk1CC;
        public int unk1D0;
        public int unk1D4;
        public int unk1D8;
        public int unk1DC;
        public int unk1E0;
        public int unk1E4;
        public int unk1E8;
        public int unk1EC;
        public int unk1F0;
        public int unk1F4;
        public int unk1F8;
        public int unk1FC;
        public int unk200;
        public int unk204;
        public int unk208;
        public int unk20C;
        public int unk210;
        public int unk214;
        public int unk218;
        public int unk21C;
        public int unk220;
        public int unk224;
        public int unk228;
        public int unk22C;
        public int unk230;
        public int unk234;
        public int unk238;
        public int unk23C;
        public int unk240;
        public int unk244;
        public int unk248;
        public int unk24C;
        public int unk250;
        public int unk254;
        public int unk258;
        public int unk25C;
        public int unk260;
        public int unk264;
        public int unk268;
        public int unk26C;
        public int unk270;
        public int unk274;
        public int unk278;
        public int unk27C;
        public int unk280;
        public int unk284;
        public int unk288;
        public int unk28C;
        public int unk290;
        public int unk294;
        public int unk298;
        public int unk29C;
        public int unk2A0;
        public int unk2A4;
        public int unk2A8;
        public int unk2AC;
        public int unk2B0;
        public int unk2B4;
        public int unk2B8;
        public int unk2BC;
        public int unk2C0;
        public int unk2C4;
        public int unk2C8;
        public int unk2CC;
        public int unk2D0;
        public int unk2D4;
        public int unk2D8;
        public int unk2DC;
        public int unk2E0;
        public int unk2E4;
        public int unk2E8;
        public int unk2EC;
        public int unk2F0;
        public int unk2F4;
        public int unk2F8;
        public int unk2FC;
        public int unk300;
        public int unk304;
        public int unk308;
        public int unk30C;
        public int unk310;
        public int unk314;
        public int unk318;
        public int unk31C;
        public int unk320;
        public int unk324;
        public int unk328;
        public int unk32C;
        public int unk330;
        public int unk334;
        public int unk338;
        public int unk33C;
        public int unk340;
        public int unk344;
        public int unk348;
        public int unk34C;
        public int unk350;
    }

    [Flags]
    public enum StatusFlags : int
    {
        Male = 0x00000001,
        Female = 0x00000002,
        AmmyUnk = 0x00000004,
        MagStormModokUnk = 0x00000008,
        NoHurtbox = 0x00000010,
        AirBlockBounce = 0x00000020,
        NoHyperDrain = 0x00000040,
        NoHitstop = 0x00000080,
        IMSentShumaUnk = 0x00000100,
        AirUnk = 0x00000200,
        ShumaUnk = 0x00000400,
        AmmyShumaUnk = 0x00000800,
        LockCharacter = 0x00001000,
        NoSnapoutNoTAC = 0x00002000,
        Unk0x4000 = 0x00004000,
        Unk0x8000 = 0x00008000,
        FriendlyFire = 0x00010000,
        NoJump = 0x00020000,
        NoDoubleJump = 0x00040000,
        Unk0x80000 = 0x00080000,
        Unk0x100000 = 0x00100000,
        NoTagIn = 0x00200000,
        Unk0x400000 = 0x00400000,
        FrankUnk = 0x00800000
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ATKInfoChunk
    {
        public int index;
        public int startup;
        public int unk008;
        public int unk00C;
        public int unk010;
        public int unk014;
        public int unk018;
        public int multiHit;
        public int unk020;
        public int unk024;
        public int unk028;
        public int unk02c;
        public int unk030;
        public int unk034;
        public int unk038;
        public int atkflags;
        public int atkflags2;
        public int unk044;
        public int hitstunAnim;
        public int blockLevel;
        public int unk050;
        public int unk054;
        public int unk058;
        public int unk05c;
        public int damage;
        public float damageScaling;
        public float damageMult;
        public float unk06c;
        public int unk070;
        public float meterGain;
        public float unk078;
        public int unk07c;
        public int unk080;
        public int unk084;
        public int unk088;
        public int unk08c;
        public int unk090;
        public int unk094;
        public int unk098;
        public float enemyPush;
        public float cornerPushInverse;
        public float playerBlockPushCorner;
        public float playerBlockPushInverse;
        public float unk0AC;
        public float unk0B0;
        public float unk0B4;
        public float unk0B8;
        public float unk0BC;
        public float unk0C0;
        public int hitstop;
        public int unk0C8;
        public int unk0CC;
        public int unk0D0;
        public int juggleHeight;
        public int unk0D8;
        public float unk0DC;
        public float juggleSpeed;
        public int unk0E4;
        public int unk0E8;
        public int unk0EC;
        public int unk0F0;
        public int unk0F4;
        public int unk0F8;
        public int unk0FC;
        public int unk100;
        public int unk104;
        public int unk108;
        public int unk10C;
        public int unk110;
        public int unk114;
        public int unk118;
        public int unk11C;
        public int unk120;
        public int unk124;
        public int unk128;
        public int unk12C;
        public int unk130;
        public int unk134;
        public int unk138;
        public int unk13C;
        public int unk140;
        public int unk144;
        public int unk148;
        public int unk14C;
        public int hitSFXGroup;
        public int hitSFX;
        public int unk158;
        public int unk15C;
        public int unk160;
        public int unk164;
        public float unk168;
        public float unk16C;
        public int unk170;
        public int unk174;
        public int unk178;
        public int unk17c;
        public int unk180;
        public int unk184;
        public int unk188;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BaseActChunk
    {
        public int index;
        public int anmchrAction;
        public int direction1;
        public int direction2;
        public int button;
        public int state;
        public int unk18;
        public int unk1C;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct CmdComboHeaderChunk
    {
        public int index;
        public int size;
        public int unk08;
        public float meterRequirement;
        public int disable;
        public int unk14;
        public int unk18;
        public int delay;
        public int anmChrAction;
        public int unk24;
        public int unk28;
        public int unk2C;
        public int unk30;
        public int unk34;
        public int unk38;
        public int unk3C;
        public int unk40;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SpatkHeaderChunk
    {
        public int index;
        public int size;
        public int unk08;
        public float meterrequirement;
        public int disable;
        public int cancelHierarchyThresh;
        public int positionState;
        public int comboState;
        public int flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SpatkStandardChunk // 02
    {
        public int subChunkType; // 02
        public int cancelWindow;
        public int chargeTime;
        public int unk0C;
        public int negativeEdge;
        public int leniencyMaybe;
        public int inputCode;
        public int unk1C;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SpatkDirectionalDashChunk // 03
    {
        public int subChunkType; // 03
        public int cancelWindow;
        public int unk08;
        public int unk0C;
        public int negativeEdge;
        public int leniencyMaybe;
        public int inputCode;
        public int unk1C;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SpatkTwoButtonChunk // 04
    {
        public int subChunkType; // 04
        public int cancelWindow;
        public int unk08;
        public int unk0C;
        public int unk10;
        public int unk14;
        public int unk18;
        public int unk1C;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SpatkDirButtonChunk // 05
    {
        public int subChunkType; // 05
        public int cancelWindow;
        public int leniencyMaybe;
        public int inputCodeDirection;
        public int inputCodeButton;
        public int unk14;
        public int unk18;
        public int unk1C;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SpatkActionChunk // 09
    {
        public int subChunkType; // 09
        public int actionClass;
        public int actionIndex;
        public int unk0C;
        public int unk10;
        public int unk14;
        public int unk18;
        public int unk1C;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SpatkStateFromChunk // 1E
    {
        public int subChunkType; // 1E
        public int stateFrom;
        public int unk08;
        public int unk0C;
        public int unk10;
        public int unk14;
        public int unk18;
        public int unk1C;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SpatkTACDHCChunk // 23
    {
        public int subChunkType; //23
        public int anmChrAction;
        public int unk08;
        public int unk0C;
        public int unk10;
        public int unk14;
        public int unk18;
        public int unk1C;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SpatkStateChangeChunk // 2F
    {
        public int subChunkType; //2F
        public int unk04;
        public int unk08;
        public int unk0C;
        public int unk10;
        public int unk14;
        public int unk18;
        public int unk1C;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SpatkProhibitedChunk // 31
    {
        public int subChunkType; //31
        public int prohibitedCategory;
        public int prohibitedID;
        public int unk0C;
        public int unk10;
        public int unk14;
        public int unk18;
        public int unk1C;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SpatkAirdashChunk // 34
    {
        public int subChunkType; //34
        public int unk04;
        public int unk08;
        public int unk0C;
        public int unk10;
        public int unk14;
        public int unk18;
        public int unk1C;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SpatkAirSpecialLimiterChunk // 35
    {
        public int subChunkType; //35
        public int limit;
        public int unk08;
        public int unk0C;
        public int unk10;
        public int unk14;
        public int unk18;
        public int unk1C;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SpatkGuardTACChunk // 38
    {
        public int subChunkType; //38
        public int unk04;
        public int unk08;
        public int unk0C;
        public int unk10;
        public int unk14;
        public int unk18;
        public int unk1C;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SpatkHyperChunk // 3A
    {
        public int subChunkType; //3A
        public int unk04;
        public int unk08;
        public int unk0C;
        public int unk10;
        public int unk14;
        public int unk18;
        public int unk1C;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SpatkPermitChainChunk // 3F
    {
        public int subChunkType; //3F
        public int validityFlags;
        public int unk08;
        public int unk0C;
        public int unk10;
        public int unk14;
        public int unk18;
        public int unk1C;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SpatkUnkChunk // ??
    {
        public int subChunkType; //??
        public int unk04;
        public int unk08;
        public int unk0C;
        public int unk10;
        public int unk14;
        public int unk18;
        public int unk1C;
    }
}