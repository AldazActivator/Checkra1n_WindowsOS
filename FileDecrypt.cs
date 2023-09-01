using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ns2
{
    // Token: 0x0200000D RID: 13
    public static class GClass1
    {
        // Token: 0x060000CA RID: 202
        [DllImport("libusb-1.0.dll")]
        public static extern int libusb_init(out IntPtr ctx);

        // Token: 0x060000CB RID: 203
        [DllImport("libusb-1.0.dll")]
        public static extern void libusb_exit(IntPtr ctx);

        // Token: 0x060000CC RID: 204
        [DllImport("libusb-1.0.dll")]
        public static extern void libusb_set_debug(IntPtr ctx, int level);

        // Token: 0x060000CD RID: 205
        [DllImport("libusb-1.0.dll")]
        public static extern int libusb_handle_events(IntPtr ctx);

        // Token: 0x060000CE RID: 206
        [DllImport("libusb-1.0.dll")]
        public static extern int libusb_set_option(IntPtr context, int option);

        // Token: 0x060000CF RID: 207
        [DllImport("libusb-1.0.dll")]
        public unsafe static extern byte* libusb_error_name(int errcode);

        // Token: 0x060000D0 RID: 208
        [DllImport("libusb-1.0.dll")]
        public unsafe static extern int libusb_get_device_list(IntPtr ctx, out GClass1.GStruct8** list);

        // Token: 0x060000D1 RID: 209
        [DllImport("libusb-1.0.dll")]
        public static extern int libusb_handle_events_completed(IntPtr pContext, IntPtr completed);

        // Token: 0x060000D2 RID: 210
        [DllImport("libusb-1.0.dll")]
        public unsafe static extern void libusb_free_device_list(GClass1.GStruct8** list, int unref_devices);

        // Token: 0x060000D3 RID: 211
        [DllImport("libusb-1.0.dll")]
        public static extern IntPtr libusb_ref_device(IntPtr dev);

        // Token: 0x060000D4 RID: 212
        [DllImport("libusb-1.0.dll")]
        public static extern void libusb_unref_device(IntPtr dev);

        // Token: 0x060000D5 RID: 213
        [DllImport("libusb-1.0.dll")]
        private static extern int libusb_get_configuration(IntPtr dev, out int config);

        // Token: 0x060000D6 RID: 214
        [DllImport("libusb-1.0.dll")]
        public unsafe static extern int libusb_get_device_descriptor(GClass1.GStruct8* dev, out GClass1.GStruct6 desc);

        // Token: 0x060000D7 RID: 215
        [DllImport("libusb-1.0.dll")]
        private unsafe static extern int libusb_get_active_config_descriptor(IntPtr dev, GClass1.GStruct11** config);

        // Token: 0x060000D8 RID: 216
        [DllImport("libusb-1.0.dll")]
        private unsafe static extern int libusb_get_config_descriptor(IntPtr dev, byte config_index, GClass1.GStruct11** config);

        // Token: 0x060000D9 RID: 217
        [DllImport("libusb-1.0.dll")]
        private unsafe static extern int libusb_get_config_descriptor_by_value(IntPtr dev, byte bConfigurationValue, GClass1.GStruct11** config);

        // Token: 0x060000DA RID: 218
        [DllImport("libusb-1.0.dll")]
        private unsafe static extern void libusb_free_config_descriptor(GClass1.GStruct11* config);

        // Token: 0x060000DB RID: 219
        [DllImport("libusb-1.0.dll")]
        public static extern byte libusb_get_bus_number(IntPtr dev);

        // Token: 0x060000DC RID: 220
        [DllImport("libusb-1.0.dll")]
        public static extern byte libusb_get_device_address(IntPtr dev);

        // Token: 0x060000DD RID: 221
        [DllImport("libusb-1.0.dll")]
        private static extern int libusb_get_device_speed(IntPtr dev);

        // Token: 0x060000DE RID: 222
        [DllImport("libusb-1.0.dll")]
        private static extern int libusb_get_max_packet_size(IntPtr dev, byte endpoint);

        // Token: 0x060000DF RID: 223
        [DllImport("libusb-1.0.dll")]
        private static extern int libusb_get_max_iso_packet_size(IntPtr dev, byte endpoint);

        // Token: 0x060000E0 RID: 224
        [DllImport("libusb-1.0.dll")]
        public unsafe static extern int libusb_open(GClass1.GStruct8* dev, out IntPtr handle);

        // Token: 0x060000E1 RID: 225
        [DllImport("libusb-1.0.dll")]
        public static extern void libusb_close(IntPtr dev_handle);

        // Token: 0x060000E2 RID: 226
        [DllImport("libusb-1.0.dll")]
        public static extern IntPtr libusb_get_device(IntPtr dev_handle);

        // Token: 0x060000E3 RID: 227
        [DllImport("libusb-1.0.dll")]
        public static extern int libusb_set_configuration(IntPtr dev, int configuration);

        // Token: 0x060000E4 RID: 228
        [DllImport("libusb-1.0.dll")]
        public static extern int libusb_claim_interface(IntPtr dev, int interface_number);

        // Token: 0x060000E5 RID: 229
        [DllImport("libusb-1.0.dll")]
        public static extern int libusb_release_interface(IntPtr dev, int interface_number);

        // Token: 0x060000E6 RID: 230
        [DllImport("libusb-1.0.dll")]
        public static extern IntPtr libusb_open_device_with_vid_pid(IntPtr ctx, ushort vendor_id, ushort product_id);

        // Token: 0x060000E7 RID: 231
        [DllImport("libusb-1.0.dll")]
        public static extern int libusb_set_interface_alt_setting(IntPtr dev, int interface_number, int alternate_setting);

        // Token: 0x060000E8 RID: 232
        [DllImport("libusb-1.0.dll")]
        public static extern int libusb_clear_halt(IntPtr dev, byte endpoint);

        // Token: 0x060000E9 RID: 233
        [DllImport("libusb-1.0.dll")]
        public static extern int libusb_reset_device(IntPtr dev);

        // Token: 0x060000EA RID: 234
        [DllImport("libusb-1.0.dll")]
        public static extern int libusb_control_transfer(IntPtr dev_handle, byte request_type, byte bRequest, ushort wValue, ushort wIndex, byte[] data, ushort wLength, uint timeout);

        // Token: 0x060000EB RID: 235
        [DllImport("libusb-1.0.dll", EntryPoint = "libusb_control_transfer")]
        public static extern int libusb_control_transfer_1(IntPtr dev_handle, byte request_type, byte bRequest, ushort wValue, ushort wIndex, IntPtr data, ushort wLength, uint timeout);

        // Token: 0x060000EC RID: 236
        [DllImport("libusb-1.0.dll")]
        public unsafe static extern int libusb_bulk_transfer(IntPtr dev_handle, byte endpoint, byte* data, int length, out int actual_length, uint timeout);

        // Token: 0x060000ED RID: 237
        [DllImport("libusb-1.0.dll")]
        public unsafe static extern int libusb_interrupt_transfer(IntPtr dev_handle, byte endpoint, byte* data, int length, out int actual_length, uint timeout);

        // Token: 0x060000EE RID: 238
        [DllImport("libusb-1.0.dll")]
        public static extern void libusb_fill_control_setup(byte[] buffer, byte request_type, byte bRequest, ushort wValue, ushort wIndex, ushort wLength);

        // Token: 0x060000EF RID: 239
        [DllImport("libusb-1.0.dll")]
        public unsafe static extern void libusb_fill_control_transfer(GClass1.GStruct12* transfer, IntPtr dev_handle, byte[] buffer, IntPtr callback, IntPtr user_data, uint timeout);

        // Token: 0x060000F0 RID: 240
        [DllImport("libusb-1.0.dll")]
        public unsafe static extern GClass1.GStruct12* libusb_alloc_transfer(int isoPackeets);

        // Token: 0x060000F1 RID: 241
        [DllImport("libusb-1.0.dll")]
        public unsafe static extern int libusb_submit_transfer(GClass1.GStruct12* transfer);

        // Token: 0x060000F2 RID: 242
        [DllImport("libusb-1.0.dll")]
        public unsafe static extern int libusb_cancel_transfer(GClass1.GStruct12* transfer);

        // Token: 0x060000F3 RID: 243
        [DllImport("libusb-1.0.dll")]
        public unsafe static extern void libusb_free_transfer(GClass1.GStruct12* transfer);

        // Token: 0x060000F4 RID: 244
        [DllImport("libusb-1.0.dll")]
        public static extern int libusb_get_string_descriptor_ascii(IntPtr dev, byte desc_index, [MarshalAs(UnmanagedType.LPStr)] StringBuilder data, int length);

        // Token: 0x04000081 RID: 129
        private const CallingConvention callingConvention_0 = CallingConvention.Winapi;

        // Token: 0x04000082 RID: 130
        private const string string_0 = "libusb-1.0.dll";

        // Token: 0x02000039 RID: 57
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct GStruct6
        {
            // Token: 0x0400015A RID: 346
            public byte byte_0;

            // Token: 0x0400015B RID: 347
            public byte byte_1;

            // Token: 0x0400015C RID: 348
            public ushort ushort_0;

            // Token: 0x0400015D RID: 349
            public byte byte_2;

            // Token: 0x0400015E RID: 350
            public byte byte_3;

            // Token: 0x0400015F RID: 351
            public byte byte_4;

            // Token: 0x04000160 RID: 352
            public byte byte_5;

            // Token: 0x04000161 RID: 353
            public ushort ushort_1;

            // Token: 0x04000162 RID: 354
            public ushort ushort_2;

            // Token: 0x04000163 RID: 355
            public ushort ushort_3;

            // Token: 0x04000164 RID: 356
            public byte byte_6;

            // Token: 0x04000165 RID: 357
            public byte byte_7;

            // Token: 0x04000166 RID: 358
            public byte byte_8;

            // Token: 0x04000167 RID: 359
            public byte byte_9;
        }

        // Token: 0x0200003A RID: 58
        public struct GStruct7
        {
            // Token: 0x04000168 RID: 360
            public byte byte_0;

            // Token: 0x04000169 RID: 361
            public byte byte_1;

            // Token: 0x0400016A RID: 362
            public byte byte_2;

            // Token: 0x0400016B RID: 363
            public byte byte_3;

            // Token: 0x0400016C RID: 364
            public ushort ushort_0;

            // Token: 0x0400016D RID: 365
            public byte byte_4;

            // Token: 0x0400016E RID: 366
            public byte byte_5;

            // Token: 0x0400016F RID: 367
            public byte byte_6;

            // Token: 0x04000170 RID: 368
            public unsafe byte* pByte_0;

            // Token: 0x04000171 RID: 369
            public int int_0;
        }

        // Token: 0x0200003B RID: 59
        public struct GStruct8
        {
            // Token: 0x04000172 RID: 370
            public IntPtr intptr_0;

            // Token: 0x04000173 RID: 371
            public int int_0;

            // Token: 0x04000174 RID: 372
            public unsafe IntPtr* pIntPtr_0;

            // Token: 0x04000175 RID: 373
            public byte byte_0;

            // Token: 0x04000176 RID: 374
            public byte byte_1;

            // Token: 0x04000177 RID: 375
            public byte byte_2;

            // Token: 0x04000178 RID: 376
            public IntPtr intptr_1;

            // Token: 0x04000179 RID: 377
            public unsafe IntPtr* pIntPtr_1;

            // Token: 0x0400017A RID: 378
            public ulong ulong_0;

            // Token: 0x0400017B RID: 379
            public byte byte_3;
        }

        // Token: 0x0200003C RID: 60
        public struct GStruct9
        {
            // Token: 0x0400017C RID: 380
            public byte byte_0;

            // Token: 0x0400017D RID: 381
            public byte byte_1;

            // Token: 0x0400017E RID: 382
            public byte byte_2;

            // Token: 0x0400017F RID: 383
            public byte byte_3;

            // Token: 0x04000180 RID: 384
            public byte byte_4;

            // Token: 0x04000181 RID: 385
            public byte byte_5;

            // Token: 0x04000182 RID: 386
            public byte byte_6;

            // Token: 0x04000183 RID: 387
            public byte byte_7;

            // Token: 0x04000184 RID: 388
            public byte byte_8;

            // Token: 0x04000185 RID: 389
            public unsafe GClass1.GStruct7* pGstruct7_0;

            // Token: 0x04000186 RID: 390
            public unsafe byte* pByte_0;

            // Token: 0x04000187 RID: 391
            public int int_0;
        }

        // Token: 0x0200003D RID: 61
        public struct GStruct10
        {
            // Token: 0x04000188 RID: 392
            public unsafe GClass1.GStruct9* pGstruct9_0;

            // Token: 0x04000189 RID: 393
            public int int_0;
        }

        // Token: 0x0200003E RID: 62
        public struct GStruct11
        {
            // Token: 0x0400018A RID: 394
            public byte byte_0;

            // Token: 0x0400018B RID: 395
            public byte byte_1;

            // Token: 0x0400018C RID: 396
            public byte byte_2;

            // Token: 0x0400018D RID: 397
            public byte byte_3;

            // Token: 0x0400018E RID: 398
            public byte byte_4;

            // Token: 0x0400018F RID: 399
            public byte byte_5;

            // Token: 0x04000190 RID: 400
            public byte byte_6;

            // Token: 0x04000191 RID: 401
            public byte byte_7;

            // Token: 0x04000192 RID: 402
            public unsafe GClass1.GStruct10* pGstruct10_0;

            // Token: 0x04000193 RID: 403
            public unsafe byte* pByte_0;

            // Token: 0x04000194 RID: 404
            public int int_0;
        }

        // Token: 0x0200003F RID: 63
        public struct GStruct12
        {
            // Token: 0x04000195 RID: 405
            public IntPtr intptr_0;

            // Token: 0x04000196 RID: 406
            public byte byte_0;

            // Token: 0x04000197 RID: 407
            public byte byte_1;

            // Token: 0x04000198 RID: 408
            public byte byte_2;

            // Token: 0x04000199 RID: 409
            public uint uint_0;

            // Token: 0x0400019A RID: 410
            public byte byte_3;

            // Token: 0x0400019B RID: 411
            public int int_0;

            // Token: 0x0400019C RID: 412
            public int int_1;

            // Token: 0x0400019D RID: 413
            public IntPtr intptr_1;

            // Token: 0x0400019E RID: 414
            public IntPtr intptr_2;

            // Token: 0x0400019F RID: 415
            public IntPtr intptr_3;

            // Token: 0x040001A0 RID: 416
            public int int_2;

            // Token: 0x040001A1 RID: 417
            public IntPtr intptr_4;
        }

        // Token: 0x02000040 RID: 64
        public struct GStruct13
        {
            // Token: 0x040001A2 RID: 418
            public byte byte_0;

            // Token: 0x040001A3 RID: 419
            public byte byte_1;

            // Token: 0x040001A4 RID: 420
            public ushort ushort_0;

            // Token: 0x040001A5 RID: 421
            public ushort ushort_1;

            // Token: 0x040001A6 RID: 422
            public ushort ushort_2;
        }
    }
}
