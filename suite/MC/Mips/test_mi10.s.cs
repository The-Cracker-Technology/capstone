# CS_ARCH_MIPS, CS_MODE_MIPS32+CS_MODE_BIG_ENDIAN, None
0x7a,0x00,0x08,0x20 = ld.b $w0, -512($at)
0x78,0x00,0x10,0x60 = ld.b $w1, ($v0)
0x79,0xff,0x18,0xa0 = ld.b $w2, 511($v1)
0x7a,0x00,0x20,0xe1 = ld.h $w3, -1024($a0)
0x7b,0x00,0x29,0x21 = ld.h $w4, -512($a1)
0x78,0x00,0x31,0x61 = ld.h $w5, ($a2)
0x79,0x00,0x39,0xa1 = ld.h $w6, 512($a3)
0x79,0xff,0x41,0xe1 = ld.h $w7, 1022($t0)
0x7a,0x00,0x4a,0x22 = ld.w $w8, -2048($t1)
0x7b,0x00,0x52,0x62 = ld.w $w9, -1024($t2)
0x7b,0x80,0x5a,0xa2 = ld.w $w10, -512($t3)
0x78,0x80,0x62,0xe2 = ld.w $w11, 512($t4)
0x79,0x00,0x6b,0x22 = ld.w $w12, 1024($t5)
0x79,0xff,0x73,0x62 = ld.w $w13, 2044($t6)
0x7a,0x00,0x7b,0xa3 = ld.d $w14, -4096($t7)
0x7b,0x00,0x83,0xe3 = ld.d $w15, -2048($s0)
0x7b,0x80,0x8c,0x23 = ld.d $w16, -1024($s1)
0x7b,0xc0,0x94,0x63 = ld.d $w17, -512($s2)
0x78,0x00,0x9c,0xa3 = ld.d $w18, ($s3)
0x78,0x40,0xa4,0xe3 = ld.d $w19, 512($s4)
0x78,0x80,0xad,0x23 = ld.d $w20, 1024($s5)
0x79,0x00,0xb5,0x63 = ld.d $w21, 2048($s6)
0x79,0xff,0xbd,0xa3 = ld.d $w22, 4088($s7)
