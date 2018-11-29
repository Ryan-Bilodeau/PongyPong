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





#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// TapStateManager
struct  TapStateManager_t1280766479  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Vector2 TapStateManager::TouchPos
	Vector2_t2243707579  ___TouchPos_4;

public:
	inline static int32_t get_offset_of_TouchPos_4() { return static_cast<int32_t>(offsetof(TapStateManager_t1280766479, ___TouchPos_4)); }
	inline Vector2_t2243707579  get_TouchPos_4() const { return ___TouchPos_4; }
	inline Vector2_t2243707579 * get_address_of_TouchPos_4() { return &___TouchPos_4; }
	inline void set_TouchPos_4(Vector2_t2243707579  value)
	{
		___TouchPos_4 = value;
	}
};

struct TapStateManager_t1280766479_StaticFields
{
public:
	// System.Boolean TapStateManager::LeftTouched
	bool ___LeftTouched_2;
	// System.Boolean TapStateManager::RightTouched
	bool ___RightTouched_3;

public:
	inline static int32_t get_offset_of_LeftTouched_2() { return static_cast<int32_t>(offsetof(TapStateManager_t1280766479_StaticFields, ___LeftTouched_2)); }
	inline bool get_LeftTouched_2() const { return ___LeftTouched_2; }
	inline bool* get_address_of_LeftTouched_2() { return &___LeftTouched_2; }
	inline void set_LeftTouched_2(bool value)
	{
		___LeftTouched_2 = value;
	}

	inline static int32_t get_offset_of_RightTouched_3() { return static_cast<int32_t>(offsetof(TapStateManager_t1280766479_StaticFields, ___RightTouched_3)); }
	inline bool get_RightTouched_3() const { return ___RightTouched_3; }
	inline bool* get_address_of_RightTouched_3() { return &___RightTouched_3; }
	inline void set_RightTouched_3(bool value)
	{
		___RightTouched_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
