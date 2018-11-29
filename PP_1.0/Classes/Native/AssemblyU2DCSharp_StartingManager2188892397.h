#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Vector22243707579.h"
#include "UnityEngine_UnityEngine_Color2020392075.h"

// StartingManager/OnPlayerLostDel
struct OnPlayerLostDel_t1604130865;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// StartingManager
struct  StartingManager_t2188892397  : public MonoBehaviour_t1158329972
{
public:
	// System.Single StartingManager::AlphaChangeSpeed
	float ___AlphaChangeSpeed_5;
	// System.Single StartingManager::MinAlpha
	float ___MinAlpha_6;
	// UnityEngine.Vector2 StartingManager::TempPos
	Vector2_t2243707579  ___TempPos_7;
	// UnityEngine.Color StartingManager::TempColor
	Color_t2020392075  ___TempColor_8;
	// System.Boolean StartingManager::Increasing
	bool ___Increasing_9;

public:
	inline static int32_t get_offset_of_AlphaChangeSpeed_5() { return static_cast<int32_t>(offsetof(StartingManager_t2188892397, ___AlphaChangeSpeed_5)); }
	inline float get_AlphaChangeSpeed_5() const { return ___AlphaChangeSpeed_5; }
	inline float* get_address_of_AlphaChangeSpeed_5() { return &___AlphaChangeSpeed_5; }
	inline void set_AlphaChangeSpeed_5(float value)
	{
		___AlphaChangeSpeed_5 = value;
	}

	inline static int32_t get_offset_of_MinAlpha_6() { return static_cast<int32_t>(offsetof(StartingManager_t2188892397, ___MinAlpha_6)); }
	inline float get_MinAlpha_6() const { return ___MinAlpha_6; }
	inline float* get_address_of_MinAlpha_6() { return &___MinAlpha_6; }
	inline void set_MinAlpha_6(float value)
	{
		___MinAlpha_6 = value;
	}

	inline static int32_t get_offset_of_TempPos_7() { return static_cast<int32_t>(offsetof(StartingManager_t2188892397, ___TempPos_7)); }
	inline Vector2_t2243707579  get_TempPos_7() const { return ___TempPos_7; }
	inline Vector2_t2243707579 * get_address_of_TempPos_7() { return &___TempPos_7; }
	inline void set_TempPos_7(Vector2_t2243707579  value)
	{
		___TempPos_7 = value;
	}

	inline static int32_t get_offset_of_TempColor_8() { return static_cast<int32_t>(offsetof(StartingManager_t2188892397, ___TempColor_8)); }
	inline Color_t2020392075  get_TempColor_8() const { return ___TempColor_8; }
	inline Color_t2020392075 * get_address_of_TempColor_8() { return &___TempColor_8; }
	inline void set_TempColor_8(Color_t2020392075  value)
	{
		___TempColor_8 = value;
	}

	inline static int32_t get_offset_of_Increasing_9() { return static_cast<int32_t>(offsetof(StartingManager_t2188892397, ___Increasing_9)); }
	inline bool get_Increasing_9() const { return ___Increasing_9; }
	inline bool* get_address_of_Increasing_9() { return &___Increasing_9; }
	inline void set_Increasing_9(bool value)
	{
		___Increasing_9 = value;
	}
};

struct StartingManager_t2188892397_StaticFields
{
public:
	// StartingManager/OnPlayerLostDel StartingManager::OnPlayerLost
	OnPlayerLostDel_t1604130865 * ___OnPlayerLost_2;
	// System.Boolean StartingManager::CanMoveArms
	bool ___CanMoveArms_3;
	// System.Boolean StartingManager::PlayerLost
	bool ___PlayerLost_4;

public:
	inline static int32_t get_offset_of_OnPlayerLost_2() { return static_cast<int32_t>(offsetof(StartingManager_t2188892397_StaticFields, ___OnPlayerLost_2)); }
	inline OnPlayerLostDel_t1604130865 * get_OnPlayerLost_2() const { return ___OnPlayerLost_2; }
	inline OnPlayerLostDel_t1604130865 ** get_address_of_OnPlayerLost_2() { return &___OnPlayerLost_2; }
	inline void set_OnPlayerLost_2(OnPlayerLostDel_t1604130865 * value)
	{
		___OnPlayerLost_2 = value;
		Il2CppCodeGenWriteBarrier(&___OnPlayerLost_2, value);
	}

	inline static int32_t get_offset_of_CanMoveArms_3() { return static_cast<int32_t>(offsetof(StartingManager_t2188892397_StaticFields, ___CanMoveArms_3)); }
	inline bool get_CanMoveArms_3() const { return ___CanMoveArms_3; }
	inline bool* get_address_of_CanMoveArms_3() { return &___CanMoveArms_3; }
	inline void set_CanMoveArms_3(bool value)
	{
		___CanMoveArms_3 = value;
	}

	inline static int32_t get_offset_of_PlayerLost_4() { return static_cast<int32_t>(offsetof(StartingManager_t2188892397_StaticFields, ___PlayerLost_4)); }
	inline bool get_PlayerLost_4() const { return ___PlayerLost_4; }
	inline bool* get_address_of_PlayerLost_4() { return &___PlayerLost_4; }
	inline void set_PlayerLost_4(bool value)
	{
		___PlayerLost_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
