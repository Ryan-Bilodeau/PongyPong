#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// GameStateManager
struct GameStateManager_t1063875770;
// GameStateManager/OnHighScorePassedDel
struct OnHighScorePassedDel_t2529849853;
// GameStateManager/OnVolumeButtonPressedDel
struct OnVolumeButtonPressedDel_t3739209567;
// UnityEngine.Sprite
struct Sprite_t309593783;
// UnityEngine.Sprite[]
struct SpriteU5BU5D_t3359083662;
// UnityEngine.Object[]
struct ObjectU5BU5D_t4217747464;
// System.Action`1<System.Boolean>
struct Action_1_t3627374100;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// GameStateManager
struct  GameStateManager_t1063875770  : public MonoBehaviour_t1158329972
{
public:
	// System.Int32 GameStateManager::Score
	int32_t ___Score_3;
	// System.Int32 GameStateManager::HighScore
	int32_t ___HighScore_4;
	// GameStateManager/OnHighScorePassedDel GameStateManager::OnHighScorePassed
	OnHighScorePassedDel_t2529849853 * ___OnHighScorePassed_5;
	// GameStateManager/OnVolumeButtonPressedDel GameStateManager::OnVolumeButtonPressed
	OnVolumeButtonPressedDel_t3739209567 * ___OnVolumeButtonPressed_6;
	// System.Boolean GameStateManager::HighScorePassed
	bool ___HighScorePassed_7;
	// System.Boolean GameStateManager::ResetScore
	bool ___ResetScore_8;
	// System.Boolean GameStateManager::CanWatchAd
	bool ___CanWatchAd_9;
	// System.Boolean GameStateManager::JustWatchedAd
	bool ___JustWatchedAd_10;
	// System.Boolean GameStateManager::Muted
	bool ___Muted_11;
	// UnityEngine.Sprite GameStateManager::MouthNormalSprite
	Sprite_t309593783 * ___MouthNormalSprite_12;
	// UnityEngine.Sprite[] GameStateManager::MouthFrownSprites
	SpriteU5BU5D_t3359083662* ___MouthFrownSprites_13;
	// UnityEngine.Sprite[] GameStateManager::MouthSmileSprites
	SpriteU5BU5D_t3359083662* ___MouthSmileSprites_14;
	// UnityEngine.Sprite[] GameStateManager::EyeNormalSprites
	SpriteU5BU5D_t3359083662* ___EyeNormalSprites_15;
	// UnityEngine.Sprite[] GameStateManager::EyeBlinkingSprites
	SpriteU5BU5D_t3359083662* ___EyeBlinkingSprites_16;
	// UnityEngine.Sprite[] GameStateManager::ArmSprites
	SpriteU5BU5D_t3359083662* ___ArmSprites_17;
	// UnityEngine.Sprite GameStateManager::VolumeOnSprite
	Sprite_t309593783 * ___VolumeOnSprite_18;
	// UnityEngine.Sprite GameStateManager::VolumeOffSprite
	Sprite_t309593783 * ___VolumeOffSprite_19;
	// UnityEngine.Sprite GameStateManager::TapToStartOnSprite
	Sprite_t309593783 * ___TapToStartOnSprite_20;
	// UnityEngine.Sprite GameStateManager::TapToStartOffSprite
	Sprite_t309593783 * ___TapToStartOffSprite_21;
	// UnityEngine.Object[] GameStateManager::TempMouthSprites
	ObjectU5BU5D_t4217747464* ___TempMouthSprites_22;
	// UnityEngine.Object[] GameStateManager::TempEyeSprites
	ObjectU5BU5D_t4217747464* ___TempEyeSprites_23;
	// UnityEngine.Object[] GameStateManager::TempArmSprites
	ObjectU5BU5D_t4217747464* ___TempArmSprites_24;

public:
	inline static int32_t get_offset_of_Score_3() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___Score_3)); }
	inline int32_t get_Score_3() const { return ___Score_3; }
	inline int32_t* get_address_of_Score_3() { return &___Score_3; }
	inline void set_Score_3(int32_t value)
	{
		___Score_3 = value;
	}

	inline static int32_t get_offset_of_HighScore_4() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___HighScore_4)); }
	inline int32_t get_HighScore_4() const { return ___HighScore_4; }
	inline int32_t* get_address_of_HighScore_4() { return &___HighScore_4; }
	inline void set_HighScore_4(int32_t value)
	{
		___HighScore_4 = value;
	}

	inline static int32_t get_offset_of_OnHighScorePassed_5() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___OnHighScorePassed_5)); }
	inline OnHighScorePassedDel_t2529849853 * get_OnHighScorePassed_5() const { return ___OnHighScorePassed_5; }
	inline OnHighScorePassedDel_t2529849853 ** get_address_of_OnHighScorePassed_5() { return &___OnHighScorePassed_5; }
	inline void set_OnHighScorePassed_5(OnHighScorePassedDel_t2529849853 * value)
	{
		___OnHighScorePassed_5 = value;
		Il2CppCodeGenWriteBarrier(&___OnHighScorePassed_5, value);
	}

	inline static int32_t get_offset_of_OnVolumeButtonPressed_6() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___OnVolumeButtonPressed_6)); }
	inline OnVolumeButtonPressedDel_t3739209567 * get_OnVolumeButtonPressed_6() const { return ___OnVolumeButtonPressed_6; }
	inline OnVolumeButtonPressedDel_t3739209567 ** get_address_of_OnVolumeButtonPressed_6() { return &___OnVolumeButtonPressed_6; }
	inline void set_OnVolumeButtonPressed_6(OnVolumeButtonPressedDel_t3739209567 * value)
	{
		___OnVolumeButtonPressed_6 = value;
		Il2CppCodeGenWriteBarrier(&___OnVolumeButtonPressed_6, value);
	}

	inline static int32_t get_offset_of_HighScorePassed_7() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___HighScorePassed_7)); }
	inline bool get_HighScorePassed_7() const { return ___HighScorePassed_7; }
	inline bool* get_address_of_HighScorePassed_7() { return &___HighScorePassed_7; }
	inline void set_HighScorePassed_7(bool value)
	{
		___HighScorePassed_7 = value;
	}

	inline static int32_t get_offset_of_ResetScore_8() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___ResetScore_8)); }
	inline bool get_ResetScore_8() const { return ___ResetScore_8; }
	inline bool* get_address_of_ResetScore_8() { return &___ResetScore_8; }
	inline void set_ResetScore_8(bool value)
	{
		___ResetScore_8 = value;
	}

	inline static int32_t get_offset_of_CanWatchAd_9() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___CanWatchAd_9)); }
	inline bool get_CanWatchAd_9() const { return ___CanWatchAd_9; }
	inline bool* get_address_of_CanWatchAd_9() { return &___CanWatchAd_9; }
	inline void set_CanWatchAd_9(bool value)
	{
		___CanWatchAd_9 = value;
	}

	inline static int32_t get_offset_of_JustWatchedAd_10() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___JustWatchedAd_10)); }
	inline bool get_JustWatchedAd_10() const { return ___JustWatchedAd_10; }
	inline bool* get_address_of_JustWatchedAd_10() { return &___JustWatchedAd_10; }
	inline void set_JustWatchedAd_10(bool value)
	{
		___JustWatchedAd_10 = value;
	}

	inline static int32_t get_offset_of_Muted_11() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___Muted_11)); }
	inline bool get_Muted_11() const { return ___Muted_11; }
	inline bool* get_address_of_Muted_11() { return &___Muted_11; }
	inline void set_Muted_11(bool value)
	{
		___Muted_11 = value;
	}

	inline static int32_t get_offset_of_MouthNormalSprite_12() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___MouthNormalSprite_12)); }
	inline Sprite_t309593783 * get_MouthNormalSprite_12() const { return ___MouthNormalSprite_12; }
	inline Sprite_t309593783 ** get_address_of_MouthNormalSprite_12() { return &___MouthNormalSprite_12; }
	inline void set_MouthNormalSprite_12(Sprite_t309593783 * value)
	{
		___MouthNormalSprite_12 = value;
		Il2CppCodeGenWriteBarrier(&___MouthNormalSprite_12, value);
	}

	inline static int32_t get_offset_of_MouthFrownSprites_13() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___MouthFrownSprites_13)); }
	inline SpriteU5BU5D_t3359083662* get_MouthFrownSprites_13() const { return ___MouthFrownSprites_13; }
	inline SpriteU5BU5D_t3359083662** get_address_of_MouthFrownSprites_13() { return &___MouthFrownSprites_13; }
	inline void set_MouthFrownSprites_13(SpriteU5BU5D_t3359083662* value)
	{
		___MouthFrownSprites_13 = value;
		Il2CppCodeGenWriteBarrier(&___MouthFrownSprites_13, value);
	}

	inline static int32_t get_offset_of_MouthSmileSprites_14() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___MouthSmileSprites_14)); }
	inline SpriteU5BU5D_t3359083662* get_MouthSmileSprites_14() const { return ___MouthSmileSprites_14; }
	inline SpriteU5BU5D_t3359083662** get_address_of_MouthSmileSprites_14() { return &___MouthSmileSprites_14; }
	inline void set_MouthSmileSprites_14(SpriteU5BU5D_t3359083662* value)
	{
		___MouthSmileSprites_14 = value;
		Il2CppCodeGenWriteBarrier(&___MouthSmileSprites_14, value);
	}

	inline static int32_t get_offset_of_EyeNormalSprites_15() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___EyeNormalSprites_15)); }
	inline SpriteU5BU5D_t3359083662* get_EyeNormalSprites_15() const { return ___EyeNormalSprites_15; }
	inline SpriteU5BU5D_t3359083662** get_address_of_EyeNormalSprites_15() { return &___EyeNormalSprites_15; }
	inline void set_EyeNormalSprites_15(SpriteU5BU5D_t3359083662* value)
	{
		___EyeNormalSprites_15 = value;
		Il2CppCodeGenWriteBarrier(&___EyeNormalSprites_15, value);
	}

	inline static int32_t get_offset_of_EyeBlinkingSprites_16() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___EyeBlinkingSprites_16)); }
	inline SpriteU5BU5D_t3359083662* get_EyeBlinkingSprites_16() const { return ___EyeBlinkingSprites_16; }
	inline SpriteU5BU5D_t3359083662** get_address_of_EyeBlinkingSprites_16() { return &___EyeBlinkingSprites_16; }
	inline void set_EyeBlinkingSprites_16(SpriteU5BU5D_t3359083662* value)
	{
		___EyeBlinkingSprites_16 = value;
		Il2CppCodeGenWriteBarrier(&___EyeBlinkingSprites_16, value);
	}

	inline static int32_t get_offset_of_ArmSprites_17() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___ArmSprites_17)); }
	inline SpriteU5BU5D_t3359083662* get_ArmSprites_17() const { return ___ArmSprites_17; }
	inline SpriteU5BU5D_t3359083662** get_address_of_ArmSprites_17() { return &___ArmSprites_17; }
	inline void set_ArmSprites_17(SpriteU5BU5D_t3359083662* value)
	{
		___ArmSprites_17 = value;
		Il2CppCodeGenWriteBarrier(&___ArmSprites_17, value);
	}

	inline static int32_t get_offset_of_VolumeOnSprite_18() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___VolumeOnSprite_18)); }
	inline Sprite_t309593783 * get_VolumeOnSprite_18() const { return ___VolumeOnSprite_18; }
	inline Sprite_t309593783 ** get_address_of_VolumeOnSprite_18() { return &___VolumeOnSprite_18; }
	inline void set_VolumeOnSprite_18(Sprite_t309593783 * value)
	{
		___VolumeOnSprite_18 = value;
		Il2CppCodeGenWriteBarrier(&___VolumeOnSprite_18, value);
	}

	inline static int32_t get_offset_of_VolumeOffSprite_19() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___VolumeOffSprite_19)); }
	inline Sprite_t309593783 * get_VolumeOffSprite_19() const { return ___VolumeOffSprite_19; }
	inline Sprite_t309593783 ** get_address_of_VolumeOffSprite_19() { return &___VolumeOffSprite_19; }
	inline void set_VolumeOffSprite_19(Sprite_t309593783 * value)
	{
		___VolumeOffSprite_19 = value;
		Il2CppCodeGenWriteBarrier(&___VolumeOffSprite_19, value);
	}

	inline static int32_t get_offset_of_TapToStartOnSprite_20() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___TapToStartOnSprite_20)); }
	inline Sprite_t309593783 * get_TapToStartOnSprite_20() const { return ___TapToStartOnSprite_20; }
	inline Sprite_t309593783 ** get_address_of_TapToStartOnSprite_20() { return &___TapToStartOnSprite_20; }
	inline void set_TapToStartOnSprite_20(Sprite_t309593783 * value)
	{
		___TapToStartOnSprite_20 = value;
		Il2CppCodeGenWriteBarrier(&___TapToStartOnSprite_20, value);
	}

	inline static int32_t get_offset_of_TapToStartOffSprite_21() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___TapToStartOffSprite_21)); }
	inline Sprite_t309593783 * get_TapToStartOffSprite_21() const { return ___TapToStartOffSprite_21; }
	inline Sprite_t309593783 ** get_address_of_TapToStartOffSprite_21() { return &___TapToStartOffSprite_21; }
	inline void set_TapToStartOffSprite_21(Sprite_t309593783 * value)
	{
		___TapToStartOffSprite_21 = value;
		Il2CppCodeGenWriteBarrier(&___TapToStartOffSprite_21, value);
	}

	inline static int32_t get_offset_of_TempMouthSprites_22() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___TempMouthSprites_22)); }
	inline ObjectU5BU5D_t4217747464* get_TempMouthSprites_22() const { return ___TempMouthSprites_22; }
	inline ObjectU5BU5D_t4217747464** get_address_of_TempMouthSprites_22() { return &___TempMouthSprites_22; }
	inline void set_TempMouthSprites_22(ObjectU5BU5D_t4217747464* value)
	{
		___TempMouthSprites_22 = value;
		Il2CppCodeGenWriteBarrier(&___TempMouthSprites_22, value);
	}

	inline static int32_t get_offset_of_TempEyeSprites_23() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___TempEyeSprites_23)); }
	inline ObjectU5BU5D_t4217747464* get_TempEyeSprites_23() const { return ___TempEyeSprites_23; }
	inline ObjectU5BU5D_t4217747464** get_address_of_TempEyeSprites_23() { return &___TempEyeSprites_23; }
	inline void set_TempEyeSprites_23(ObjectU5BU5D_t4217747464* value)
	{
		___TempEyeSprites_23 = value;
		Il2CppCodeGenWriteBarrier(&___TempEyeSprites_23, value);
	}

	inline static int32_t get_offset_of_TempArmSprites_24() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770, ___TempArmSprites_24)); }
	inline ObjectU5BU5D_t4217747464* get_TempArmSprites_24() const { return ___TempArmSprites_24; }
	inline ObjectU5BU5D_t4217747464** get_address_of_TempArmSprites_24() { return &___TempArmSprites_24; }
	inline void set_TempArmSprites_24(ObjectU5BU5D_t4217747464* value)
	{
		___TempArmSprites_24 = value;
		Il2CppCodeGenWriteBarrier(&___TempArmSprites_24, value);
	}
};

struct GameStateManager_t1063875770_StaticFields
{
public:
	// GameStateManager GameStateManager::Instance
	GameStateManager_t1063875770 * ___Instance_2;
	// System.Action`1<System.Boolean> GameStateManager::<>f__am$cache0
	Action_1_t3627374100 * ___U3CU3Ef__amU24cache0_25;

public:
	inline static int32_t get_offset_of_Instance_2() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770_StaticFields, ___Instance_2)); }
	inline GameStateManager_t1063875770 * get_Instance_2() const { return ___Instance_2; }
	inline GameStateManager_t1063875770 ** get_address_of_Instance_2() { return &___Instance_2; }
	inline void set_Instance_2(GameStateManager_t1063875770 * value)
	{
		___Instance_2 = value;
		Il2CppCodeGenWriteBarrier(&___Instance_2, value);
	}

	inline static int32_t get_offset_of_U3CU3Ef__amU24cache0_25() { return static_cast<int32_t>(offsetof(GameStateManager_t1063875770_StaticFields, ___U3CU3Ef__amU24cache0_25)); }
	inline Action_1_t3627374100 * get_U3CU3Ef__amU24cache0_25() const { return ___U3CU3Ef__amU24cache0_25; }
	inline Action_1_t3627374100 ** get_address_of_U3CU3Ef__amU24cache0_25() { return &___U3CU3Ef__amU24cache0_25; }
	inline void set_U3CU3Ef__amU24cache0_25(Action_1_t3627374100 * value)
	{
		___U3CU3Ef__amU24cache0_25 = value;
		Il2CppCodeGenWriteBarrier(&___U3CU3Ef__amU24cache0_25, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
