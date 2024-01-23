﻿// Copyright © Clinton Ingram and Contributors.  Licensed under the MIT License.

//------------------------------------------------------------------------------
//	<auto-generated>
//		This code was generated from a template.
//		Manual changes will be overwritten if the code is regenerated.
//	</auto-generated>
//------------------------------------------------------------------------------

namespace Blake2Fast.Implementation;

#if BLAKE2_PUBLIC
public
#else
internal
#endif
unsafe partial struct Blake2sHashState
{
	private static void mixScalar(uint* sh, uint* m)
	{
		uint m00 = m[00];
		uint m01 = m[01];
		uint m02 = m[02];
		uint m03 = m[03];
		uint m04 = m[04];
		uint m05 = m[05];
		uint m06 = m[06];
		uint m07 = m[07];
		uint m08 = m[08];
		uint m09 = m[09];
		uint m10 = m[10];
		uint m11 = m[11];
		uint m12 = m[12];
		uint m13 = m[13];
		uint m14 = m[14];
		uint m15 = m[15];

		uint v00 = sh[0];
		uint v01 = sh[1];
		uint v02 = sh[2];
		uint v03 = sh[3];
		uint v04 = sh[4];
		uint v05 = sh[5];
		uint v06 = sh[6];
		uint v07 = sh[7];

		uint v08 = 0x6a09e667u;
		uint v09 = 0xbb67ae85u;
		uint v10 = 0x3c6ef372u;
		uint v11 = 0xa54ff53au;
		uint v12 = 0x510e527fu;
		uint v13 = 0x9b05688cu;
		uint v14 = 0x1f83d9abu;
		uint v15 = 0x5be0cd19u;

		v12 ^= sh[8];  // t[0]
		v13 ^= sh[9];  // t[1]
		v14 ^= sh[10]; // f[0]

		//ROUND 1
		v00 += m00;
		v00 += v04;
		v12 ^= v00;
		v12 = (v12 >> 16) ^ (v12 << 16);
		v08 += v12;
		v04 ^= v08;
		v04 = (v04 >> 12) ^ (v04 << 20);

		v01 += m02;
		v01 += v05;
		v13 ^= v01;
		v13 = (v13 >> 16) ^ (v13 << 16);
		v09 += v13;
		v05 ^= v09;
		v05 = (v05 >> 12) ^ (v05 << 20);

		v02 += m04;
		v02 += v06;
		v14 ^= v02;
		v14 = (v14 >> 16) ^ (v14 << 16);
		v10 += v14;
		v06 ^= v10;
		v06 = (v06 >> 12) ^ (v06 << 20);

		v03 += m06;
		v03 += v07;
		v15 ^= v03;
		v15 = (v15 >> 16) ^ (v15 << 16);
		v11 += v15;
		v07 ^= v11;
		v07 = (v07 >> 12) ^ (v07 << 20);

		v02 += m05;
		v02 += v06;
		v14 ^= v02;
		v14 = (v14 >>  8) ^ (v14 << 24);
		v10 += v14;
		v06 ^= v10;
		v06 = (v06 >>  7) ^ (v06 << 25);

		v03 += m07;
		v03 += v07;
		v15 ^= v03;
		v15 = (v15 >>  8) ^ (v15 << 24);
		v11 += v15;
		v07 ^= v11;
		v07 = (v07 >>  7) ^ (v07 << 25);

		v00 += m01;
		v00 += v04;
		v12 ^= v00;
		v12 = (v12 >>  8) ^ (v12 << 24);
		v08 += v12;
		v04 ^= v08;
		v04 = (v04 >>  7) ^ (v04 << 25);

		v01 += m03;
		v01 += v05;
		v13 ^= v01;
		v13 = (v13 >>  8) ^ (v13 << 24);
		v09 += v13;
		v05 ^= v09;
		v05 = (v05 >>  7) ^ (v05 << 25);

		v00 += m08;
		v00 += v05;
		v15 ^= v00;
		v15 = (v15 >> 16) ^ (v15 << 16);
		v10 += v15;
		v05 ^= v10;
		v05 = (v05 >> 12) ^ (v05 << 20);

		v01 += m10;
		v01 += v06;
		v12 ^= v01;
		v12 = (v12 >> 16) ^ (v12 << 16);
		v11 += v12;
		v06 ^= v11;
		v06 = (v06 >> 12) ^ (v06 << 20);

		v02 += m12;
		v02 += v07;
		v13 ^= v02;
		v13 = (v13 >> 16) ^ (v13 << 16);
		v08 += v13;
		v07 ^= v08;
		v07 = (v07 >> 12) ^ (v07 << 20);

		v03 += m14;
		v03 += v04;
		v14 ^= v03;
		v14 = (v14 >> 16) ^ (v14 << 16);
		v09 += v14;
		v04 ^= v09;
		v04 = (v04 >> 12) ^ (v04 << 20);

		v02 += m13;
		v02 += v07;
		v13 ^= v02;
		v13 = (v13 >>  8) ^ (v13 << 24);
		v08 += v13;
		v07 ^= v08;
		v07 = (v07 >>  7) ^ (v07 << 25);

		v03 += m15;
		v03 += v04;
		v14 ^= v03;
		v14 = (v14 >>  8) ^ (v14 << 24);
		v09 += v14;
		v04 ^= v09;
		v04 = (v04 >>  7) ^ (v04 << 25);

		v00 += m09;
		v00 += v05;
		v15 ^= v00;
		v15 = (v15 >>  8) ^ (v15 << 24);
		v10 += v15;
		v05 ^= v10;
		v05 = (v05 >>  7) ^ (v05 << 25);

		v01 += m11;
		v01 += v06;
		v12 ^= v01;
		v12 = (v12 >>  8) ^ (v12 << 24);
		v11 += v12;
		v06 ^= v11;
		v06 = (v06 >>  7) ^ (v06 << 25);

		//ROUND 2
		v00 += m14;
		v00 += v04;
		v12 ^= v00;
		v12 = (v12 >> 16) ^ (v12 << 16);
		v08 += v12;
		v04 ^= v08;
		v04 = (v04 >> 12) ^ (v04 << 20);

		v01 += m04;
		v01 += v05;
		v13 ^= v01;
		v13 = (v13 >> 16) ^ (v13 << 16);
		v09 += v13;
		v05 ^= v09;
		v05 = (v05 >> 12) ^ (v05 << 20);

		v02 += m09;
		v02 += v06;
		v14 ^= v02;
		v14 = (v14 >> 16) ^ (v14 << 16);
		v10 += v14;
		v06 ^= v10;
		v06 = (v06 >> 12) ^ (v06 << 20);

		v03 += m13;
		v03 += v07;
		v15 ^= v03;
		v15 = (v15 >> 16) ^ (v15 << 16);
		v11 += v15;
		v07 ^= v11;
		v07 = (v07 >> 12) ^ (v07 << 20);

		v02 += m15;
		v02 += v06;
		v14 ^= v02;
		v14 = (v14 >>  8) ^ (v14 << 24);
		v10 += v14;
		v06 ^= v10;
		v06 = (v06 >>  7) ^ (v06 << 25);

		v03 += m06;
		v03 += v07;
		v15 ^= v03;
		v15 = (v15 >>  8) ^ (v15 << 24);
		v11 += v15;
		v07 ^= v11;
		v07 = (v07 >>  7) ^ (v07 << 25);

		v00 += m10;
		v00 += v04;
		v12 ^= v00;
		v12 = (v12 >>  8) ^ (v12 << 24);
		v08 += v12;
		v04 ^= v08;
		v04 = (v04 >>  7) ^ (v04 << 25);

		v01 += m08;
		v01 += v05;
		v13 ^= v01;
		v13 = (v13 >>  8) ^ (v13 << 24);
		v09 += v13;
		v05 ^= v09;
		v05 = (v05 >>  7) ^ (v05 << 25);

		v00 += m01;
		v00 += v05;
		v15 ^= v00;
		v15 = (v15 >> 16) ^ (v15 << 16);
		v10 += v15;
		v05 ^= v10;
		v05 = (v05 >> 12) ^ (v05 << 20);

		v01 += m00;
		v01 += v06;
		v12 ^= v01;
		v12 = (v12 >> 16) ^ (v12 << 16);
		v11 += v12;
		v06 ^= v11;
		v06 = (v06 >> 12) ^ (v06 << 20);

		v02 += m11;
		v02 += v07;
		v13 ^= v02;
		v13 = (v13 >> 16) ^ (v13 << 16);
		v08 += v13;
		v07 ^= v08;
		v07 = (v07 >> 12) ^ (v07 << 20);

		v03 += m05;
		v03 += v04;
		v14 ^= v03;
		v14 = (v14 >> 16) ^ (v14 << 16);
		v09 += v14;
		v04 ^= v09;
		v04 = (v04 >> 12) ^ (v04 << 20);

		v02 += m07;
		v02 += v07;
		v13 ^= v02;
		v13 = (v13 >>  8) ^ (v13 << 24);
		v08 += v13;
		v07 ^= v08;
		v07 = (v07 >>  7) ^ (v07 << 25);

		v03 += m03;
		v03 += v04;
		v14 ^= v03;
		v14 = (v14 >>  8) ^ (v14 << 24);
		v09 += v14;
		v04 ^= v09;
		v04 = (v04 >>  7) ^ (v04 << 25);

		v00 += m12;
		v00 += v05;
		v15 ^= v00;
		v15 = (v15 >>  8) ^ (v15 << 24);
		v10 += v15;
		v05 ^= v10;
		v05 = (v05 >>  7) ^ (v05 << 25);

		v01 += m02;
		v01 += v06;
		v12 ^= v01;
		v12 = (v12 >>  8) ^ (v12 << 24);
		v11 += v12;
		v06 ^= v11;
		v06 = (v06 >>  7) ^ (v06 << 25);

		//ROUND 3
		v00 += m11;
		v00 += v04;
		v12 ^= v00;
		v12 = (v12 >> 16) ^ (v12 << 16);
		v08 += v12;
		v04 ^= v08;
		v04 = (v04 >> 12) ^ (v04 << 20);

		v01 += m12;
		v01 += v05;
		v13 ^= v01;
		v13 = (v13 >> 16) ^ (v13 << 16);
		v09 += v13;
		v05 ^= v09;
		v05 = (v05 >> 12) ^ (v05 << 20);

		v02 += m05;
		v02 += v06;
		v14 ^= v02;
		v14 = (v14 >> 16) ^ (v14 << 16);
		v10 += v14;
		v06 ^= v10;
		v06 = (v06 >> 12) ^ (v06 << 20);

		v03 += m15;
		v03 += v07;
		v15 ^= v03;
		v15 = (v15 >> 16) ^ (v15 << 16);
		v11 += v15;
		v07 ^= v11;
		v07 = (v07 >> 12) ^ (v07 << 20);

		v02 += m02;
		v02 += v06;
		v14 ^= v02;
		v14 = (v14 >>  8) ^ (v14 << 24);
		v10 += v14;
		v06 ^= v10;
		v06 = (v06 >>  7) ^ (v06 << 25);

		v03 += m13;
		v03 += v07;
		v15 ^= v03;
		v15 = (v15 >>  8) ^ (v15 << 24);
		v11 += v15;
		v07 ^= v11;
		v07 = (v07 >>  7) ^ (v07 << 25);

		v00 += m08;
		v00 += v04;
		v12 ^= v00;
		v12 = (v12 >>  8) ^ (v12 << 24);
		v08 += v12;
		v04 ^= v08;
		v04 = (v04 >>  7) ^ (v04 << 25);

		v01 += m00;
		v01 += v05;
		v13 ^= v01;
		v13 = (v13 >>  8) ^ (v13 << 24);
		v09 += v13;
		v05 ^= v09;
		v05 = (v05 >>  7) ^ (v05 << 25);

		v00 += m10;
		v00 += v05;
		v15 ^= v00;
		v15 = (v15 >> 16) ^ (v15 << 16);
		v10 += v15;
		v05 ^= v10;
		v05 = (v05 >> 12) ^ (v05 << 20);

		v01 += m03;
		v01 += v06;
		v12 ^= v01;
		v12 = (v12 >> 16) ^ (v12 << 16);
		v11 += v12;
		v06 ^= v11;
		v06 = (v06 >> 12) ^ (v06 << 20);

		v02 += m07;
		v02 += v07;
		v13 ^= v02;
		v13 = (v13 >> 16) ^ (v13 << 16);
		v08 += v13;
		v07 ^= v08;
		v07 = (v07 >> 12) ^ (v07 << 20);

		v03 += m09;
		v03 += v04;
		v14 ^= v03;
		v14 = (v14 >> 16) ^ (v14 << 16);
		v09 += v14;
		v04 ^= v09;
		v04 = (v04 >> 12) ^ (v04 << 20);

		v02 += m01;
		v02 += v07;
		v13 ^= v02;
		v13 = (v13 >>  8) ^ (v13 << 24);
		v08 += v13;
		v07 ^= v08;
		v07 = (v07 >>  7) ^ (v07 << 25);

		v03 += m04;
		v03 += v04;
		v14 ^= v03;
		v14 = (v14 >>  8) ^ (v14 << 24);
		v09 += v14;
		v04 ^= v09;
		v04 = (v04 >>  7) ^ (v04 << 25);

		v00 += m14;
		v00 += v05;
		v15 ^= v00;
		v15 = (v15 >>  8) ^ (v15 << 24);
		v10 += v15;
		v05 ^= v10;
		v05 = (v05 >>  7) ^ (v05 << 25);

		v01 += m06;
		v01 += v06;
		v12 ^= v01;
		v12 = (v12 >>  8) ^ (v12 << 24);
		v11 += v12;
		v06 ^= v11;
		v06 = (v06 >>  7) ^ (v06 << 25);

		//ROUND 4
		v00 += m07;
		v00 += v04;
		v12 ^= v00;
		v12 = (v12 >> 16) ^ (v12 << 16);
		v08 += v12;
		v04 ^= v08;
		v04 = (v04 >> 12) ^ (v04 << 20);

		v01 += m03;
		v01 += v05;
		v13 ^= v01;
		v13 = (v13 >> 16) ^ (v13 << 16);
		v09 += v13;
		v05 ^= v09;
		v05 = (v05 >> 12) ^ (v05 << 20);

		v02 += m13;
		v02 += v06;
		v14 ^= v02;
		v14 = (v14 >> 16) ^ (v14 << 16);
		v10 += v14;
		v06 ^= v10;
		v06 = (v06 >> 12) ^ (v06 << 20);

		v03 += m11;
		v03 += v07;
		v15 ^= v03;
		v15 = (v15 >> 16) ^ (v15 << 16);
		v11 += v15;
		v07 ^= v11;
		v07 = (v07 >> 12) ^ (v07 << 20);

		v02 += m12;
		v02 += v06;
		v14 ^= v02;
		v14 = (v14 >>  8) ^ (v14 << 24);
		v10 += v14;
		v06 ^= v10;
		v06 = (v06 >>  7) ^ (v06 << 25);

		v03 += m14;
		v03 += v07;
		v15 ^= v03;
		v15 = (v15 >>  8) ^ (v15 << 24);
		v11 += v15;
		v07 ^= v11;
		v07 = (v07 >>  7) ^ (v07 << 25);

		v00 += m09;
		v00 += v04;
		v12 ^= v00;
		v12 = (v12 >>  8) ^ (v12 << 24);
		v08 += v12;
		v04 ^= v08;
		v04 = (v04 >>  7) ^ (v04 << 25);

		v01 += m01;
		v01 += v05;
		v13 ^= v01;
		v13 = (v13 >>  8) ^ (v13 << 24);
		v09 += v13;
		v05 ^= v09;
		v05 = (v05 >>  7) ^ (v05 << 25);

		v00 += m02;
		v00 += v05;
		v15 ^= v00;
		v15 = (v15 >> 16) ^ (v15 << 16);
		v10 += v15;
		v05 ^= v10;
		v05 = (v05 >> 12) ^ (v05 << 20);

		v01 += m05;
		v01 += v06;
		v12 ^= v01;
		v12 = (v12 >> 16) ^ (v12 << 16);
		v11 += v12;
		v06 ^= v11;
		v06 = (v06 >> 12) ^ (v06 << 20);

		v02 += m04;
		v02 += v07;
		v13 ^= v02;
		v13 = (v13 >> 16) ^ (v13 << 16);
		v08 += v13;
		v07 ^= v08;
		v07 = (v07 >> 12) ^ (v07 << 20);

		v03 += m15;
		v03 += v04;
		v14 ^= v03;
		v14 = (v14 >> 16) ^ (v14 << 16);
		v09 += v14;
		v04 ^= v09;
		v04 = (v04 >> 12) ^ (v04 << 20);

		v02 += m00;
		v02 += v07;
		v13 ^= v02;
		v13 = (v13 >>  8) ^ (v13 << 24);
		v08 += v13;
		v07 ^= v08;
		v07 = (v07 >>  7) ^ (v07 << 25);

		v03 += m08;
		v03 += v04;
		v14 ^= v03;
		v14 = (v14 >>  8) ^ (v14 << 24);
		v09 += v14;
		v04 ^= v09;
		v04 = (v04 >>  7) ^ (v04 << 25);

		v00 += m06;
		v00 += v05;
		v15 ^= v00;
		v15 = (v15 >>  8) ^ (v15 << 24);
		v10 += v15;
		v05 ^= v10;
		v05 = (v05 >>  7) ^ (v05 << 25);

		v01 += m10;
		v01 += v06;
		v12 ^= v01;
		v12 = (v12 >>  8) ^ (v12 << 24);
		v11 += v12;
		v06 ^= v11;
		v06 = (v06 >>  7) ^ (v06 << 25);

		//ROUND 5
		v00 += m09;
		v00 += v04;
		v12 ^= v00;
		v12 = (v12 >> 16) ^ (v12 << 16);
		v08 += v12;
		v04 ^= v08;
		v04 = (v04 >> 12) ^ (v04 << 20);

		v01 += m05;
		v01 += v05;
		v13 ^= v01;
		v13 = (v13 >> 16) ^ (v13 << 16);
		v09 += v13;
		v05 ^= v09;
		v05 = (v05 >> 12) ^ (v05 << 20);

		v02 += m02;
		v02 += v06;
		v14 ^= v02;
		v14 = (v14 >> 16) ^ (v14 << 16);
		v10 += v14;
		v06 ^= v10;
		v06 = (v06 >> 12) ^ (v06 << 20);

		v03 += m10;
		v03 += v07;
		v15 ^= v03;
		v15 = (v15 >> 16) ^ (v15 << 16);
		v11 += v15;
		v07 ^= v11;
		v07 = (v07 >> 12) ^ (v07 << 20);

		v02 += m04;
		v02 += v06;
		v14 ^= v02;
		v14 = (v14 >>  8) ^ (v14 << 24);
		v10 += v14;
		v06 ^= v10;
		v06 = (v06 >>  7) ^ (v06 << 25);

		v03 += m15;
		v03 += v07;
		v15 ^= v03;
		v15 = (v15 >>  8) ^ (v15 << 24);
		v11 += v15;
		v07 ^= v11;
		v07 = (v07 >>  7) ^ (v07 << 25);

		v00 += m00;
		v00 += v04;
		v12 ^= v00;
		v12 = (v12 >>  8) ^ (v12 << 24);
		v08 += v12;
		v04 ^= v08;
		v04 = (v04 >>  7) ^ (v04 << 25);

		v01 += m07;
		v01 += v05;
		v13 ^= v01;
		v13 = (v13 >>  8) ^ (v13 << 24);
		v09 += v13;
		v05 ^= v09;
		v05 = (v05 >>  7) ^ (v05 << 25);

		v00 += m14;
		v00 += v05;
		v15 ^= v00;
		v15 = (v15 >> 16) ^ (v15 << 16);
		v10 += v15;
		v05 ^= v10;
		v05 = (v05 >> 12) ^ (v05 << 20);

		v01 += m11;
		v01 += v06;
		v12 ^= v01;
		v12 = (v12 >> 16) ^ (v12 << 16);
		v11 += v12;
		v06 ^= v11;
		v06 = (v06 >> 12) ^ (v06 << 20);

		v02 += m06;
		v02 += v07;
		v13 ^= v02;
		v13 = (v13 >> 16) ^ (v13 << 16);
		v08 += v13;
		v07 ^= v08;
		v07 = (v07 >> 12) ^ (v07 << 20);

		v03 += m03;
		v03 += v04;
		v14 ^= v03;
		v14 = (v14 >> 16) ^ (v14 << 16);
		v09 += v14;
		v04 ^= v09;
		v04 = (v04 >> 12) ^ (v04 << 20);

		v02 += m08;
		v02 += v07;
		v13 ^= v02;
		v13 = (v13 >>  8) ^ (v13 << 24);
		v08 += v13;
		v07 ^= v08;
		v07 = (v07 >>  7) ^ (v07 << 25);

		v03 += m13;
		v03 += v04;
		v14 ^= v03;
		v14 = (v14 >>  8) ^ (v14 << 24);
		v09 += v14;
		v04 ^= v09;
		v04 = (v04 >>  7) ^ (v04 << 25);

		v00 += m01;
		v00 += v05;
		v15 ^= v00;
		v15 = (v15 >>  8) ^ (v15 << 24);
		v10 += v15;
		v05 ^= v10;
		v05 = (v05 >>  7) ^ (v05 << 25);

		v01 += m12;
		v01 += v06;
		v12 ^= v01;
		v12 = (v12 >>  8) ^ (v12 << 24);
		v11 += v12;
		v06 ^= v11;
		v06 = (v06 >>  7) ^ (v06 << 25);

		//ROUND 6
		v00 += m02;
		v00 += v04;
		v12 ^= v00;
		v12 = (v12 >> 16) ^ (v12 << 16);
		v08 += v12;
		v04 ^= v08;
		v04 = (v04 >> 12) ^ (v04 << 20);

		v01 += m06;
		v01 += v05;
		v13 ^= v01;
		v13 = (v13 >> 16) ^ (v13 << 16);
		v09 += v13;
		v05 ^= v09;
		v05 = (v05 >> 12) ^ (v05 << 20);

		v02 += m00;
		v02 += v06;
		v14 ^= v02;
		v14 = (v14 >> 16) ^ (v14 << 16);
		v10 += v14;
		v06 ^= v10;
		v06 = (v06 >> 12) ^ (v06 << 20);

		v03 += m08;
		v03 += v07;
		v15 ^= v03;
		v15 = (v15 >> 16) ^ (v15 << 16);
		v11 += v15;
		v07 ^= v11;
		v07 = (v07 >> 12) ^ (v07 << 20);

		v02 += m11;
		v02 += v06;
		v14 ^= v02;
		v14 = (v14 >>  8) ^ (v14 << 24);
		v10 += v14;
		v06 ^= v10;
		v06 = (v06 >>  7) ^ (v06 << 25);

		v03 += m03;
		v03 += v07;
		v15 ^= v03;
		v15 = (v15 >>  8) ^ (v15 << 24);
		v11 += v15;
		v07 ^= v11;
		v07 = (v07 >>  7) ^ (v07 << 25);

		v00 += m12;
		v00 += v04;
		v12 ^= v00;
		v12 = (v12 >>  8) ^ (v12 << 24);
		v08 += v12;
		v04 ^= v08;
		v04 = (v04 >>  7) ^ (v04 << 25);

		v01 += m10;
		v01 += v05;
		v13 ^= v01;
		v13 = (v13 >>  8) ^ (v13 << 24);
		v09 += v13;
		v05 ^= v09;
		v05 = (v05 >>  7) ^ (v05 << 25);

		v00 += m04;
		v00 += v05;
		v15 ^= v00;
		v15 = (v15 >> 16) ^ (v15 << 16);
		v10 += v15;
		v05 ^= v10;
		v05 = (v05 >> 12) ^ (v05 << 20);

		v01 += m07;
		v01 += v06;
		v12 ^= v01;
		v12 = (v12 >> 16) ^ (v12 << 16);
		v11 += v12;
		v06 ^= v11;
		v06 = (v06 >> 12) ^ (v06 << 20);

		v02 += m15;
		v02 += v07;
		v13 ^= v02;
		v13 = (v13 >> 16) ^ (v13 << 16);
		v08 += v13;
		v07 ^= v08;
		v07 = (v07 >> 12) ^ (v07 << 20);

		v03 += m01;
		v03 += v04;
		v14 ^= v03;
		v14 = (v14 >> 16) ^ (v14 << 16);
		v09 += v14;
		v04 ^= v09;
		v04 = (v04 >> 12) ^ (v04 << 20);

		v02 += m14;
		v02 += v07;
		v13 ^= v02;
		v13 = (v13 >>  8) ^ (v13 << 24);
		v08 += v13;
		v07 ^= v08;
		v07 = (v07 >>  7) ^ (v07 << 25);

		v03 += m09;
		v03 += v04;
		v14 ^= v03;
		v14 = (v14 >>  8) ^ (v14 << 24);
		v09 += v14;
		v04 ^= v09;
		v04 = (v04 >>  7) ^ (v04 << 25);

		v00 += m13;
		v00 += v05;
		v15 ^= v00;
		v15 = (v15 >>  8) ^ (v15 << 24);
		v10 += v15;
		v05 ^= v10;
		v05 = (v05 >>  7) ^ (v05 << 25);

		v01 += m05;
		v01 += v06;
		v12 ^= v01;
		v12 = (v12 >>  8) ^ (v12 << 24);
		v11 += v12;
		v06 ^= v11;
		v06 = (v06 >>  7) ^ (v06 << 25);

		//ROUND 7
		v00 += m12;
		v00 += v04;
		v12 ^= v00;
		v12 = (v12 >> 16) ^ (v12 << 16);
		v08 += v12;
		v04 ^= v08;
		v04 = (v04 >> 12) ^ (v04 << 20);

		v01 += m01;
		v01 += v05;
		v13 ^= v01;
		v13 = (v13 >> 16) ^ (v13 << 16);
		v09 += v13;
		v05 ^= v09;
		v05 = (v05 >> 12) ^ (v05 << 20);

		v02 += m14;
		v02 += v06;
		v14 ^= v02;
		v14 = (v14 >> 16) ^ (v14 << 16);
		v10 += v14;
		v06 ^= v10;
		v06 = (v06 >> 12) ^ (v06 << 20);

		v03 += m04;
		v03 += v07;
		v15 ^= v03;
		v15 = (v15 >> 16) ^ (v15 << 16);
		v11 += v15;
		v07 ^= v11;
		v07 = (v07 >> 12) ^ (v07 << 20);

		v02 += m13;
		v02 += v06;
		v14 ^= v02;
		v14 = (v14 >>  8) ^ (v14 << 24);
		v10 += v14;
		v06 ^= v10;
		v06 = (v06 >>  7) ^ (v06 << 25);

		v03 += m10;
		v03 += v07;
		v15 ^= v03;
		v15 = (v15 >>  8) ^ (v15 << 24);
		v11 += v15;
		v07 ^= v11;
		v07 = (v07 >>  7) ^ (v07 << 25);

		v00 += m05;
		v00 += v04;
		v12 ^= v00;
		v12 = (v12 >>  8) ^ (v12 << 24);
		v08 += v12;
		v04 ^= v08;
		v04 = (v04 >>  7) ^ (v04 << 25);

		v01 += m15;
		v01 += v05;
		v13 ^= v01;
		v13 = (v13 >>  8) ^ (v13 << 24);
		v09 += v13;
		v05 ^= v09;
		v05 = (v05 >>  7) ^ (v05 << 25);

		v00 += m00;
		v00 += v05;
		v15 ^= v00;
		v15 = (v15 >> 16) ^ (v15 << 16);
		v10 += v15;
		v05 ^= v10;
		v05 = (v05 >> 12) ^ (v05 << 20);

		v01 += m06;
		v01 += v06;
		v12 ^= v01;
		v12 = (v12 >> 16) ^ (v12 << 16);
		v11 += v12;
		v06 ^= v11;
		v06 = (v06 >> 12) ^ (v06 << 20);

		v02 += m09;
		v02 += v07;
		v13 ^= v02;
		v13 = (v13 >> 16) ^ (v13 << 16);
		v08 += v13;
		v07 ^= v08;
		v07 = (v07 >> 12) ^ (v07 << 20);

		v03 += m08;
		v03 += v04;
		v14 ^= v03;
		v14 = (v14 >> 16) ^ (v14 << 16);
		v09 += v14;
		v04 ^= v09;
		v04 = (v04 >> 12) ^ (v04 << 20);

		v02 += m02;
		v02 += v07;
		v13 ^= v02;
		v13 = (v13 >>  8) ^ (v13 << 24);
		v08 += v13;
		v07 ^= v08;
		v07 = (v07 >>  7) ^ (v07 << 25);

		v03 += m11;
		v03 += v04;
		v14 ^= v03;
		v14 = (v14 >>  8) ^ (v14 << 24);
		v09 += v14;
		v04 ^= v09;
		v04 = (v04 >>  7) ^ (v04 << 25);

		v00 += m07;
		v00 += v05;
		v15 ^= v00;
		v15 = (v15 >>  8) ^ (v15 << 24);
		v10 += v15;
		v05 ^= v10;
		v05 = (v05 >>  7) ^ (v05 << 25);

		v01 += m03;
		v01 += v06;
		v12 ^= v01;
		v12 = (v12 >>  8) ^ (v12 << 24);
		v11 += v12;
		v06 ^= v11;
		v06 = (v06 >>  7) ^ (v06 << 25);

		//ROUND 8
		v00 += m13;
		v00 += v04;
		v12 ^= v00;
		v12 = (v12 >> 16) ^ (v12 << 16);
		v08 += v12;
		v04 ^= v08;
		v04 = (v04 >> 12) ^ (v04 << 20);

		v01 += m07;
		v01 += v05;
		v13 ^= v01;
		v13 = (v13 >> 16) ^ (v13 << 16);
		v09 += v13;
		v05 ^= v09;
		v05 = (v05 >> 12) ^ (v05 << 20);

		v02 += m12;
		v02 += v06;
		v14 ^= v02;
		v14 = (v14 >> 16) ^ (v14 << 16);
		v10 += v14;
		v06 ^= v10;
		v06 = (v06 >> 12) ^ (v06 << 20);

		v03 += m03;
		v03 += v07;
		v15 ^= v03;
		v15 = (v15 >> 16) ^ (v15 << 16);
		v11 += v15;
		v07 ^= v11;
		v07 = (v07 >> 12) ^ (v07 << 20);

		v02 += m01;
		v02 += v06;
		v14 ^= v02;
		v14 = (v14 >>  8) ^ (v14 << 24);
		v10 += v14;
		v06 ^= v10;
		v06 = (v06 >>  7) ^ (v06 << 25);

		v03 += m09;
		v03 += v07;
		v15 ^= v03;
		v15 = (v15 >>  8) ^ (v15 << 24);
		v11 += v15;
		v07 ^= v11;
		v07 = (v07 >>  7) ^ (v07 << 25);

		v00 += m11;
		v00 += v04;
		v12 ^= v00;
		v12 = (v12 >>  8) ^ (v12 << 24);
		v08 += v12;
		v04 ^= v08;
		v04 = (v04 >>  7) ^ (v04 << 25);

		v01 += m14;
		v01 += v05;
		v13 ^= v01;
		v13 = (v13 >>  8) ^ (v13 << 24);
		v09 += v13;
		v05 ^= v09;
		v05 = (v05 >>  7) ^ (v05 << 25);

		v00 += m05;
		v00 += v05;
		v15 ^= v00;
		v15 = (v15 >> 16) ^ (v15 << 16);
		v10 += v15;
		v05 ^= v10;
		v05 = (v05 >> 12) ^ (v05 << 20);

		v01 += m15;
		v01 += v06;
		v12 ^= v01;
		v12 = (v12 >> 16) ^ (v12 << 16);
		v11 += v12;
		v06 ^= v11;
		v06 = (v06 >> 12) ^ (v06 << 20);

		v02 += m08;
		v02 += v07;
		v13 ^= v02;
		v13 = (v13 >> 16) ^ (v13 << 16);
		v08 += v13;
		v07 ^= v08;
		v07 = (v07 >> 12) ^ (v07 << 20);

		v03 += m02;
		v03 += v04;
		v14 ^= v03;
		v14 = (v14 >> 16) ^ (v14 << 16);
		v09 += v14;
		v04 ^= v09;
		v04 = (v04 >> 12) ^ (v04 << 20);

		v02 += m06;
		v02 += v07;
		v13 ^= v02;
		v13 = (v13 >>  8) ^ (v13 << 24);
		v08 += v13;
		v07 ^= v08;
		v07 = (v07 >>  7) ^ (v07 << 25);

		v03 += m10;
		v03 += v04;
		v14 ^= v03;
		v14 = (v14 >>  8) ^ (v14 << 24);
		v09 += v14;
		v04 ^= v09;
		v04 = (v04 >>  7) ^ (v04 << 25);

		v00 += m00;
		v00 += v05;
		v15 ^= v00;
		v15 = (v15 >>  8) ^ (v15 << 24);
		v10 += v15;
		v05 ^= v10;
		v05 = (v05 >>  7) ^ (v05 << 25);

		v01 += m04;
		v01 += v06;
		v12 ^= v01;
		v12 = (v12 >>  8) ^ (v12 << 24);
		v11 += v12;
		v06 ^= v11;
		v06 = (v06 >>  7) ^ (v06 << 25);

		//ROUND 9
		v00 += m06;
		v00 += v04;
		v12 ^= v00;
		v12 = (v12 >> 16) ^ (v12 << 16);
		v08 += v12;
		v04 ^= v08;
		v04 = (v04 >> 12) ^ (v04 << 20);

		v01 += m14;
		v01 += v05;
		v13 ^= v01;
		v13 = (v13 >> 16) ^ (v13 << 16);
		v09 += v13;
		v05 ^= v09;
		v05 = (v05 >> 12) ^ (v05 << 20);

		v02 += m11;
		v02 += v06;
		v14 ^= v02;
		v14 = (v14 >> 16) ^ (v14 << 16);
		v10 += v14;
		v06 ^= v10;
		v06 = (v06 >> 12) ^ (v06 << 20);

		v03 += m00;
		v03 += v07;
		v15 ^= v03;
		v15 = (v15 >> 16) ^ (v15 << 16);
		v11 += v15;
		v07 ^= v11;
		v07 = (v07 >> 12) ^ (v07 << 20);

		v02 += m03;
		v02 += v06;
		v14 ^= v02;
		v14 = (v14 >>  8) ^ (v14 << 24);
		v10 += v14;
		v06 ^= v10;
		v06 = (v06 >>  7) ^ (v06 << 25);

		v03 += m08;
		v03 += v07;
		v15 ^= v03;
		v15 = (v15 >>  8) ^ (v15 << 24);
		v11 += v15;
		v07 ^= v11;
		v07 = (v07 >>  7) ^ (v07 << 25);

		v00 += m15;
		v00 += v04;
		v12 ^= v00;
		v12 = (v12 >>  8) ^ (v12 << 24);
		v08 += v12;
		v04 ^= v08;
		v04 = (v04 >>  7) ^ (v04 << 25);

		v01 += m09;
		v01 += v05;
		v13 ^= v01;
		v13 = (v13 >>  8) ^ (v13 << 24);
		v09 += v13;
		v05 ^= v09;
		v05 = (v05 >>  7) ^ (v05 << 25);

		v00 += m12;
		v00 += v05;
		v15 ^= v00;
		v15 = (v15 >> 16) ^ (v15 << 16);
		v10 += v15;
		v05 ^= v10;
		v05 = (v05 >> 12) ^ (v05 << 20);

		v01 += m13;
		v01 += v06;
		v12 ^= v01;
		v12 = (v12 >> 16) ^ (v12 << 16);
		v11 += v12;
		v06 ^= v11;
		v06 = (v06 >> 12) ^ (v06 << 20);

		v02 += m01;
		v02 += v07;
		v13 ^= v02;
		v13 = (v13 >> 16) ^ (v13 << 16);
		v08 += v13;
		v07 ^= v08;
		v07 = (v07 >> 12) ^ (v07 << 20);

		v03 += m10;
		v03 += v04;
		v14 ^= v03;
		v14 = (v14 >> 16) ^ (v14 << 16);
		v09 += v14;
		v04 ^= v09;
		v04 = (v04 >> 12) ^ (v04 << 20);

		v02 += m04;
		v02 += v07;
		v13 ^= v02;
		v13 = (v13 >>  8) ^ (v13 << 24);
		v08 += v13;
		v07 ^= v08;
		v07 = (v07 >>  7) ^ (v07 << 25);

		v03 += m05;
		v03 += v04;
		v14 ^= v03;
		v14 = (v14 >>  8) ^ (v14 << 24);
		v09 += v14;
		v04 ^= v09;
		v04 = (v04 >>  7) ^ (v04 << 25);

		v00 += m02;
		v00 += v05;
		v15 ^= v00;
		v15 = (v15 >>  8) ^ (v15 << 24);
		v10 += v15;
		v05 ^= v10;
		v05 = (v05 >>  7) ^ (v05 << 25);

		v01 += m07;
		v01 += v06;
		v12 ^= v01;
		v12 = (v12 >>  8) ^ (v12 << 24);
		v11 += v12;
		v06 ^= v11;
		v06 = (v06 >>  7) ^ (v06 << 25);

		//ROUND 10
		v00 += m10;
		v00 += v04;
		v12 ^= v00;
		v12 = (v12 >> 16) ^ (v12 << 16);
		v08 += v12;
		v04 ^= v08;
		v04 = (v04 >> 12) ^ (v04 << 20);

		v01 += m08;
		v01 += v05;
		v13 ^= v01;
		v13 = (v13 >> 16) ^ (v13 << 16);
		v09 += v13;
		v05 ^= v09;
		v05 = (v05 >> 12) ^ (v05 << 20);

		v02 += m07;
		v02 += v06;
		v14 ^= v02;
		v14 = (v14 >> 16) ^ (v14 << 16);
		v10 += v14;
		v06 ^= v10;
		v06 = (v06 >> 12) ^ (v06 << 20);

		v03 += m01;
		v03 += v07;
		v15 ^= v03;
		v15 = (v15 >> 16) ^ (v15 << 16);
		v11 += v15;
		v07 ^= v11;
		v07 = (v07 >> 12) ^ (v07 << 20);

		v02 += m06;
		v02 += v06;
		v14 ^= v02;
		v14 = (v14 >>  8) ^ (v14 << 24);
		v10 += v14;
		v06 ^= v10;
		v06 = (v06 >>  7) ^ (v06 << 25);

		v03 += m05;
		v03 += v07;
		v15 ^= v03;
		v15 = (v15 >>  8) ^ (v15 << 24);
		v11 += v15;
		v07 ^= v11;
		v07 = (v07 >>  7) ^ (v07 << 25);

		v00 += m02;
		v00 += v04;
		v12 ^= v00;
		v12 = (v12 >>  8) ^ (v12 << 24);
		v08 += v12;
		v04 ^= v08;
		v04 = (v04 >>  7) ^ (v04 << 25);

		v01 += m04;
		v01 += v05;
		v13 ^= v01;
		v13 = (v13 >>  8) ^ (v13 << 24);
		v09 += v13;
		v05 ^= v09;
		v05 = (v05 >>  7) ^ (v05 << 25);

		v00 += m15;
		v00 += v05;
		v15 ^= v00;
		v15 = (v15 >> 16) ^ (v15 << 16);
		v10 += v15;
		v05 ^= v10;
		v05 = (v05 >> 12) ^ (v05 << 20);

		v01 += m09;
		v01 += v06;
		v12 ^= v01;
		v12 = (v12 >> 16) ^ (v12 << 16);
		v11 += v12;
		v06 ^= v11;
		v06 = (v06 >> 12) ^ (v06 << 20);

		v02 += m03;
		v02 += v07;
		v13 ^= v02;
		v13 = (v13 >> 16) ^ (v13 << 16);
		v08 += v13;
		v07 ^= v08;
		v07 = (v07 >> 12) ^ (v07 << 20);

		v03 += m13;
		v03 += v04;
		v14 ^= v03;
		v14 = (v14 >> 16) ^ (v14 << 16);
		v09 += v14;
		v04 ^= v09;
		v04 = (v04 >> 12) ^ (v04 << 20);

		v02 += m12;
		v02 += v07;
		v13 ^= v02;
		v13 = (v13 >>  8) ^ (v13 << 24);
		v08 += v13;
		v07 ^= v08;
		v07 = (v07 >>  7) ^ (v07 << 25);

		v03 += m00;
		v03 += v04;
		v14 ^= v03;
		v14 = (v14 >>  8) ^ (v14 << 24);
		v09 += v14;
		v04 ^= v09;
		v04 = (v04 >>  7) ^ (v04 << 25);

		v00 += m11;
		v00 += v05;
		v15 ^= v00;
		v15 = (v15 >>  8) ^ (v15 << 24);
		v10 += v15;
		v05 ^= v10;
		v05 = (v05 >>  7) ^ (v05 << 25);

		v01 += m14;
		v01 += v06;
		v12 ^= v01;
		v12 = (v12 >>  8) ^ (v12 << 24);
		v11 += v12;
		v06 ^= v11;
		v06 = (v06 >>  7) ^ (v06 << 25);

		sh[0] ^= v00 ^ v08;
		sh[1] ^= v01 ^ v09;
		sh[2] ^= v02 ^ v10;
		sh[3] ^= v03 ^ v11;
		sh[4] ^= v04 ^ v12;
		sh[5] ^= v05 ^ v13;
		sh[6] ^= v06 ^ v14;
		sh[7] ^= v07 ^ v15;
	}
}
