#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Color2020392075.h"





#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// BallManager
struct  BallManager_t622326248  : public MonoBehaviour_t1158329972
{
public:
	// System.Single BallManager::LaunchForce
	float ___LaunchForce_4;
	// System.Single BallManager::LaunchVariance
	float ___LaunchVariance_5;
	// UnityEngine.Color BallManager::TempColor
	Color_t2020392075  ___TempColor_6;
	// UnityEngine.Color BallManager::TempColorBg
	Color_t2020392075  ___TempColorBg_7;
	// UnityEngine.Color BallManager::TempColorFg
	Color_t2020392075  ___TempColorFg_8;
	// System.Boolean BallManager::CountingDown
	bool ___CountingDown_9;

public:
	inline static int32_t get_offset_of_LaunchForce_4() { return static_cast<int32_t>(offsetof(BallManager_t622326248, ___LaunchForce_4)); }
	inline float get_LaunchForce_4() const { return ___LaunchForce_4; }
	inline float* get_address_of_LaunchForce_4() { return &___LaunchForce_4; }
	inline void set_LaunchForce_4(float value)
	{
		___LaunchForce_4 = value;
	}

	inline static int32_t get_offset_of_LaunchVariance_5() { return static_cast<int32_t>(offsetof(BallManager_t622326248, ___LaunchVariance_5)); }
	inline float get_LaunchVariance_5() const { return ___LaunchVariance_5; }
	inline float* get_address_of_LaunchVariance_5() { return &___LaunchVariance_5; }
	inline void set_LaunchVariance_5(float value)
	{
		___LaunchVariance_5 = value;
	}

	inline static int32_t get_offset_of_TempColor_6() { return static_cast<int32_t>(offsetof(BallManager_t622326248, ___TempColor_6)); }
	inline Color_t2020392075  get_TempColor_6() const { return ___TempColor_6; }
	inline Color_t2020392075 * get_address_of_TempColor_6() { return &___TempColor_6; }
	inline void set_TempColor_6(Color_t2020392075  value)
	{
		___TempColor_6 = value;
	}

	inline static int32_t get_offset_of_TempColorBg_7() { return static_cast<int32_t>(offsetof(BallManager_t622326248, ___TempColorBg_7)); }
	inline Color_t2020392075  get_TempColorBg_7() const { return ___TempColorBg_7; }
	inline Color_t2020392075 * get_address_of_TempColorBg_7() { return &___TempColorBg_7; }
	inline void set_TempColorBg_7(Color_t2020392075  value)
	{
		___TempColorBg_7 = value;
	}

	inline static int32_t get_offset_of_TempColorFg_8() { return static_cast<int32_t>(offsetof(BallManager_t622326248, ___TempColorFg_8)); }
	inline Color_t2020392075  get_TempColorFg_8() const { return ___TempColorFg_8; }
	inline Color_t2020392075 * get_address_of_TempColorFg_8() { return &___TempColorFg_8; }
	inline void set_TempColorFg_8(Color_t2020392075  value)
	{
		___TempColorFg_8 = value;
	}

	inline static int32_t get_offset_of_CountingDown_9() { return static_cast<int32_t>(offsetof(BallManager_t622326248, ___CountingDown_9)); }
	inline bool get_CountingDown_9() const { return ___CountingDown_9; }
	inline bool* get_address_of_CountingDown_9() { return &___CountingDown_9; }
	inline void set_CountingDown_9(bool value)
	{
		___CountingDown_9 = value;
	}
};

struct BallManager_t622326248_StaticFields
{
public:
	// System.Boolean BallManager::CanLaunch
	bool ___CanLaunch_2;
	// System.Int32 BallManager::HitCounter
	int32_t ___HitCounter_3;

public:
	inline static int32_t get_offset_of_CanLaunch_2() { return static_cast<int32_t>(offsetof(BallManager_t622326248_StaticFields, ___CanLaunch_2)); }
	inline bool get_CanLaunch_2() const { return ___CanLaunch_2; }
	inline bool* get_address_of_CanLaunch_2() { return &___CanLaunch_2; }
	inline void set_CanLaunch_2(bool value)
	{
		___CanLaunch_2 = value;
	}

	inline static int32_t get_offset_of_HitCounter_3() { return static_cast<int32_t>(offsetof(BallManager_t622326248_StaticFields, ___HitCounter_3)); }
	inline int32_t get_HitCounter_3() const { return ___HitCounter_3; }
	inline int32_t* get_address_of_HitCounter_3() { return &___HitCounter_3; }
	inline void set_HitCounter_3(int32_t value)
	{
		___HitCounter_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
