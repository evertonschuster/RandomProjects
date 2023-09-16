```

BenchmarkDotNet v0.13.6, Windows 11 (10.0.22621.2283/22H2/2022Update/SunValley2)
Intel Core i5-8400 CPU 2.80GHz (Coffee Lake), 1 CPU, 6 logical and 6 physical cores
.NET SDK 7.0.400
  [Host]     : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT AVX2


```
|        Method | SearchTextSearch | ReplaceTextSearch |   TextSize |           Mean |         Error |        StdDev |         Median |    Gen0 |    Gen1 |    Gen2 | Allocated |
|-------------- |----------------- |------------------ |----------- |---------------:|--------------:|--------------:|---------------:|--------:|--------:|--------:|----------:|
| **StringReplace** |       **replace1_1** |        **replace1_1** |     **text10** |       **7.711 ns** |     **0.0030 ns** |     **0.0023 ns** |       **7.712 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |        replace1_1 |     text10 |      53.363 ns |     0.1124 ns |     0.0878 ns |      53.350 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace1_1** |        **replace1_1** |     **text50** |       **7.607 ns** |     **0.0546 ns** |     **0.0511 ns** |       **7.609 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |        replace1_1 |     text50 |      59.884 ns |     0.1762 ns |     0.1562 ns |      59.925 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace1_1** |        **replace1_1** |    **text100** |       **7.200 ns** |     **0.0252 ns** |     **0.0224 ns** |       **7.188 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |        replace1_1 |    text100 |      63.715 ns |     0.6577 ns |     0.6152 ns |      63.476 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace1_1** |        **replace1_1** |    **text500** |       **7.196 ns** |     **0.0169 ns** |     **0.0150 ns** |       **7.190 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |        replace1_1 |    text500 |     348.558 ns |     1.4826 ns |     1.3868 ns |     348.962 ns |  0.2174 |       - |       - |    1024 B |
| **StringReplace** |       **replace1_1** |        **replace1_1** |  **text1_000** |       **7.610 ns** |     **0.0936 ns** |     **0.0876 ns** |       **7.627 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |        replace1_1 |  text1_000 |     501.256 ns |     3.7244 ns |     3.4838 ns |     500.938 ns |  0.4301 |       - |       - |    2024 B |
| **StringReplace** |       **replace1_1** |        **replace1_1** |  **text5_000** |       **7.219 ns** |     **0.0244 ns** |     **0.0228 ns** |       **7.210 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |        replace1_1 |  text5_000 |   1,273.268 ns |    16.0803 ns |    12.5545 ns |   1,272.125 ns |  2.1267 |       - |       - |   10024 B |
| **StringReplace** |       **replace1_1** |        **replace1_1** | **text10_000** |       **7.365 ns** |     **0.0259 ns** |     **0.0242 ns** |       **7.352 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |        replace1_1 | text10_000 |   2,322.284 ns |     9.9223 ns |     9.2813 ns |   2,325.954 ns |  4.2343 |       - |       - |   20024 B |
| **StringReplace** |       **replace1_1** |        **replace1_1** | **text50_000** |       **7.381 ns** |     **0.0234 ns** |     **0.0196 ns** |       **7.380 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |        replace1_1 | text50_000 |  35,067.150 ns |   300.3328 ns |   280.9314 ns |  35,037.817 ns | 31.1890 | 31.1890 | 31.1890 |  100045 B |
| **StringReplace** |       **replace1_1** |        **replace2_1** |     **text10** |       **9.615 ns** |     **0.0131 ns** |     **0.0123 ns** |       **9.611 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |        replace2_1 |     text10 |      56.788 ns |     0.1304 ns |     0.1156 ns |      56.792 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace1_1** |        **replace2_1** |     **text50** |      **13.408 ns** |     **0.0472 ns** |     **0.0441 ns** |      **13.415 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |        replace2_1 |     text50 |      58.980 ns |     0.1406 ns |     0.1316 ns |      58.931 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace1_1** |        **replace2_1** |    **text100** |      **15.575 ns** |     **0.0341 ns** |     **0.0302 ns** |      **15.565 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |        replace2_1 |    text100 |      64.271 ns |     0.1666 ns |     0.1477 ns |      64.278 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace1_1** |        **replace2_1** |    **text500** |     **132.080 ns** |     **0.9339 ns** |     **0.8279 ns** |     **132.131 ns** |  **0.2193** |       **-** |       **-** |    **1032 B** |
| RegexrReplace |       replace1_1 |        replace2_1 |    text500 |     364.644 ns |     1.0121 ns |     0.9467 ns |     364.827 ns |  0.2193 |       - |       - |    1032 B |
| **StringReplace** |       **replace1_1** |        **replace2_1** |  **text1_000** |     **230.242 ns** |     **1.7864 ns** |     **1.6710 ns** |     **229.805 ns** |  **0.4318** |       **-** |       **-** |    **2032 B** |
| RegexrReplace |       replace1_1 |        replace2_1 |  text1_000 |     483.853 ns |     3.2776 ns |     2.9055 ns |     484.893 ns |  0.4311 |       - |       - |    2032 B |
| **StringReplace** |       **replace1_1** |        **replace2_1** |  **text5_000** |     **840.887 ns** |    **12.7490 ns** |    **11.3017 ns** |     **844.930 ns** |  **2.1315** |       **-** |       **-** |   **10040 B** |
| RegexrReplace |       replace1_1 |        replace2_1 |  text5_000 |   1,269.688 ns |    15.6979 ns |    14.6839 ns |   1,279.261 ns |  2.1305 |       - |       - |   10040 B |
| **StringReplace** |       **replace1_1** |        **replace2_1** | **text10_000** |   **1,761.632 ns** |    **26.1679 ns** |    **24.4774 ns** |   **1,746.244 ns** |  **4.2362** |       **-** |       **-** |   **20040 B** |
| RegexrReplace |       replace1_1 |        replace2_1 | text10_000 |   2,297.638 ns |    29.6053 ns |    27.6928 ns |   2,300.176 ns |  4.2343 |       - |       - |   20040 B |
| **StringReplace** |       **replace1_1** |        **replace2_1** | **text50_000** |  **31,624.631 ns** |   **375.7903 ns** |   **351.5144 ns** |  **31,556.201 ns** | **31.1890** | **31.1890** | **31.1890** |  **100123 B** |
| RegexrReplace |       replace1_1 |        replace2_1 | text50_000 |  35,283.403 ns |   306.9630 ns |   287.1334 ns |  35,317.145 ns | 31.1890 | 31.1890 | 31.1890 |  100133 B |
| **StringReplace** |       **replace1_1** |        **replace3_1** |     **text10** |       **9.621 ns** |     **0.0297 ns** |     **0.0278 ns** |       **9.606 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |        replace3_1 |     text10 |      55.869 ns |     0.2641 ns |     0.2206 ns |      55.791 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace1_1** |        **replace3_1** |     **text50** |      **13.378 ns** |     **0.0167 ns** |     **0.0148 ns** |      **13.376 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |        replace3_1 |     text50 |      61.044 ns |     0.1240 ns |     0.1160 ns |      61.035 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace1_1** |        **replace3_1** |    **text100** |      **15.605 ns** |     **0.0631 ns** |     **0.0590 ns** |      **15.616 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |        replace3_1 |    text100 |      62.528 ns |     0.1420 ns |     0.1328 ns |      62.458 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace1_1** |        **replace3_1** |    **text500** |     **133.772 ns** |     **1.0615 ns** |     **0.9929 ns** |     **134.134 ns** |  **0.2193** |       **-** |       **-** |    **1032 B** |
| RegexrReplace |       replace1_1 |        replace3_1 |    text500 |     348.007 ns |     1.1600 ns |     1.0851 ns |     347.992 ns |  0.2193 |       - |       - |    1032 B |
| **StringReplace** |       **replace1_1** |        **replace3_1** |  **text1_000** |     **229.479 ns** |     **1.2274 ns** |     **1.1482 ns** |     **229.998 ns** |  **0.4334** |       **-** |       **-** |    **2040 B** |
| RegexrReplace |       replace1_1 |        replace3_1 |  text1_000 |     473.174 ns |     2.2076 ns |     1.9569 ns |     472.428 ns |  0.4330 |       - |       - |    2040 B |
| **StringReplace** |       **replace1_1** |        **replace3_1** |  **text5_000** |     **843.528 ns** |     **3.7046 ns** |     **3.4653 ns** |     **845.626 ns** |  **2.1315** |       **-** |       **-** |   **10048 B** |
| RegexrReplace |       replace1_1 |        replace3_1 |  text5_000 |   1,251.321 ns |     2.4772 ns |     2.1960 ns |   1,251.548 ns |  2.1305 |       - |       - |   10048 B |
| **StringReplace** |       **replace1_1** |        **replace3_1** | **text10_000** |   **1,762.126 ns** |     **1.7241 ns** |     **1.4397 ns** |   **1,761.641 ns** |  **4.2553** |       **-** |       **-** |   **20056 B** |
| RegexrReplace |       replace1_1 |        replace3_1 | text10_000 |   2,319.235 ns |    21.0469 ns |    18.6575 ns |   2,312.114 ns |  4.2534 |       - |       - |   20056 B |
| **StringReplace** |       **replace1_1** |        **replace3_1** | **text50_000** |  **31,624.475 ns** |   **148.8631 ns** |   **139.2466 ns** |  **31,689.067 ns** | **31.2195** | **31.2195** | **31.2195** |  **100203 B** |
| RegexrReplace |       replace1_1 |        replace3_1 | text50_000 |  35,460.240 ns |   235.7366 ns |   220.5081 ns |  35,440.216 ns | 31.1890 | 31.1890 | 31.1890 |  100213 B |
| **StringReplace** |       **replace1_1** |        **replace5_1** |     **text10** |       **9.638 ns** |     **0.0320 ns** |     **0.0284 ns** |       **9.628 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |        replace5_1 |     text10 |      56.565 ns |     0.0943 ns |     0.0882 ns |      56.574 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace1_1** |        **replace5_1** |     **text50** |      **13.402 ns** |     **0.0415 ns** |     **0.0388 ns** |      **13.385 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |        replace5_1 |     text50 |      55.513 ns |     0.0972 ns |     0.0910 ns |      55.533 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace1_1** |        **replace5_1** |    **text100** |      **15.566 ns** |     **0.0309 ns** |     **0.0289 ns** |      **15.553 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |        replace5_1 |    text100 |      65.612 ns |     0.2642 ns |     0.2471 ns |      65.606 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace1_1** |        **replace5_1** |    **text500** |     **132.579 ns** |     **0.5186 ns** |     **0.4851 ns** |     **132.714 ns** |  **0.2210** |       **-** |       **-** |    **1040 B** |
| RegexrReplace |       replace1_1 |        replace5_1 |    text500 |     349.161 ns |     1.2662 ns |     1.1844 ns |     349.498 ns |  0.2208 |       - |       - |    1040 B |
| **StringReplace** |       **replace1_1** |        **replace5_1** |  **text1_000** |     **227.175 ns** |     **1.8781 ns** |     **1.7568 ns** |     **228.196 ns** |  **0.4351** |       **-** |       **-** |    **2048 B** |
| RegexrReplace |       replace1_1 |        replace5_1 |  text1_000 |     481.004 ns |     2.1047 ns |     1.9688 ns |     480.326 ns |  0.4349 |       - |       - |    2048 B |
| **StringReplace** |       **replace1_1** |        **replace5_1** |  **text5_000** |     **837.504 ns** |     **6.0347 ns** |     **5.6448 ns** |     **840.377 ns** |  **2.1362** |       **-** |       **-** |   **10072 B** |
| RegexrReplace |       replace1_1 |        replace5_1 |  text5_000 |   1,262.912 ns |     6.1689 ns |     5.7704 ns |   1,260.849 ns |  2.1362 |       - |       - |   10072 B |
| **StringReplace** |       **replace1_1** |        **replace5_1** | **text10_000** |   **1,765.080 ns** |     **3.1582 ns** |     **2.6372 ns** |   **1,763.833 ns** |  **4.2553** |       **-** |       **-** |   **20088 B** |
| RegexrReplace |       replace1_1 |        replace5_1 | text10_000 |   2,328.682 ns |    20.2844 ns |    18.9741 ns |   2,322.643 ns |  4.2534 |       - |       - |   20088 B |
| **StringReplace** |       **replace1_1** |        **replace5_1** | **text50_000** |  **31,567.698 ns** |   **249.5349 ns** |   **233.4151 ns** |  **31,537.259 ns** | **31.1890** | **31.1890** | **31.1890** |  **100371 B** |
| RegexrReplace |       replace1_1 |        replace5_1 | text50_000 |  35,110.552 ns |   321.1209 ns |   300.3766 ns |  35,047.034 ns | 31.1890 | 31.1890 | 31.1890 |  100381 B |
| **StringReplace** |       **replace1_1** |        **replace8_1** |     **text10** |       **9.622 ns** |     **0.0312 ns** |     **0.0292 ns** |       **9.616 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |        replace8_1 |     text10 |      55.379 ns |     0.0787 ns |     0.0657 ns |      55.386 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace1_1** |        **replace8_1** |     **text50** |      **13.400 ns** |     **0.0580 ns** |     **0.0514 ns** |      **13.404 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |        replace8_1 |     text50 |      61.069 ns |     0.1346 ns |     0.1193 ns |      61.033 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace1_1** |        **replace8_1** |    **text100** |      **15.560 ns** |     **0.0550 ns** |     **0.0487 ns** |      **15.548 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |        replace8_1 |    text100 |      58.356 ns |     0.1187 ns |     0.0991 ns |      58.395 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace1_1** |        **replace8_1** |    **text500** |     **134.402 ns** |     **0.6069 ns** |     **0.5380 ns** |     **134.505 ns** |  **0.2227** |       **-** |       **-** |    **1048 B** |
| RegexrReplace |       replace1_1 |        replace8_1 |    text500 |     345.972 ns |     2.0771 ns |     1.9430 ns |     346.169 ns |  0.2227 |       - |       - |    1048 B |
| **StringReplace** |       **replace1_1** |        **replace8_1** |  **text1_000** |     **229.040 ns** |     **2.0809 ns** |     **1.9465 ns** |     **230.321 ns** |  **0.4385** |       **-** |       **-** |    **2064 B** |
| RegexrReplace |       replace1_1 |        replace8_1 |  text1_000 |     490.769 ns |     1.8217 ns |     1.7041 ns |     491.562 ns |  0.4377 |       - |       - |    2064 B |
| **StringReplace** |       **replace1_1** |        **replace8_1** |  **text5_000** |     **842.097 ns** |     **0.5494 ns** |     **0.4871 ns** |     **841.984 ns** |  **2.1410** |       **-** |       **-** |   **10096 B** |
| RegexrReplace |       replace1_1 |        replace8_1 |  text5_000 |   1,306.247 ns |     6.0845 ns |     5.3937 ns |   1,305.870 ns |  2.1400 |       - |       - |   10096 B |
| **StringReplace** |       **replace1_1** |        **replace8_1** | **text10_000** |   **1,765.383 ns** |     **3.7319 ns** |     **3.3082 ns** |   **1,766.672 ns** |  **4.2553** |       **-** |       **-** |   **20120 B** |
| RegexrReplace |       replace1_1 |        replace8_1 | text10_000 |   2,310.720 ns |    10.8740 ns |    10.1715 ns |   2,305.977 ns |  4.2534 |       - |       - |   20120 B |
| **StringReplace** |       **replace1_1** |        **replace8_1** | **text50_000** |  **31,402.274 ns** |   **164.2447 ns** |   **153.6346 ns** |  **31,424.518 ns** | **31.1890** | **31.1890** | **31.1890** |  **100539 B** |
| RegexrReplace |       replace1_1 |        replace8_1 | text50_000 |  35,089.069 ns |   257.7237 ns |   241.0749 ns |  34,999.738 ns | 31.1890 | 31.1890 | 31.1890 |  100549 B |
| **StringReplace** |       **replace1_1** |       **replace13_1** |     **text10** |       **9.637 ns** |     **0.0198 ns** |     **0.0185 ns** |       **9.640 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |       replace13_1 |     text10 |      51.829 ns |     0.0781 ns |     0.0731 ns |      51.816 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace1_1** |       **replace13_1** |     **text50** |      **13.357 ns** |     **0.0082 ns** |     **0.0064 ns** |      **13.357 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |       replace13_1 |     text50 |      59.795 ns |     0.1639 ns |     0.1453 ns |      59.791 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace1_1** |       **replace13_1** |    **text100** |      **15.761 ns** |     **0.1158 ns** |     **0.0967 ns** |      **15.727 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |       replace13_1 |    text100 |      62.936 ns |     1.2914 ns |     1.3261 ns |      61.869 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace1_1** |       **replace13_1** |    **text500** |     **134.854 ns** |     **0.6983 ns** |     **0.6190 ns** |     **134.825 ns** |  **0.2277** |       **-** |       **-** |    **1072 B** |
| RegexrReplace |       replace1_1 |       replace13_1 |    text500 |     353.779 ns |     0.7936 ns |     0.7423 ns |     353.698 ns |  0.2275 |       - |       - |    1072 B |
| **StringReplace** |       **replace1_1** |       **replace13_1** |  **text1_000** |     **231.898 ns** |     **3.9651 ns** |     **3.7090 ns** |     **233.043 ns** |  **0.4435** |       **-** |       **-** |    **2088 B** |
| RegexrReplace |       replace1_1 |       replace13_1 |  text1_000 |     491.638 ns |     0.9945 ns |     0.9302 ns |     491.948 ns |  0.4435 |       - |       - |    2088 B |
| **StringReplace** |       **replace1_1** |       **replace13_1** |  **text5_000** |     **844.633 ns** |     **6.2729 ns** |     **5.8677 ns** |     **843.753 ns** |  **2.1544** |       **-** |       **-** |   **10160 B** |
| RegexrReplace |       replace1_1 |       replace13_1 |  text5_000 |   1,243.965 ns |     9.4897 ns |     8.8767 ns |   1,246.714 ns |  2.1534 |       - |       - |   10160 B |
| **StringReplace** |       **replace1_1** |       **replace13_1** | **text10_000** |   **1,787.568 ns** |    **21.6590 ns** |    **20.2599 ns** |   **1,793.702 ns** |  **4.2725** |       **-** |       **-** |   **20200 B** |
| RegexrReplace |       replace1_1 |       replace13_1 | text10_000 |   2,303.971 ns |    38.8759 ns |    36.3645 ns |   2,320.684 ns |  4.2725 |       - |       - |   20200 B |
| **StringReplace** |       **replace1_1** |       **replace13_1** | **text50_000** |  **31,608.260 ns** |   **329.1445 ns** |   **307.8820 ns** |  **31,590.710 ns** | **31.1890** | **31.1890** | **31.1890** |  **100963 B** |
| RegexrReplace |       replace1_1 |       replace13_1 | text50_000 |  35,264.479 ns |   272.6520 ns |   241.6989 ns |  35,289.532 ns | 31.1890 | 31.1890 | 31.1890 |  100973 B |
| **StringReplace** |       **replace1_1** |       **replace21_1** |     **text10** |       **9.636 ns** |     **0.0308 ns** |     **0.0273 ns** |       **9.628 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |       replace21_1 |     text10 |      56.183 ns |     0.3247 ns |     0.3037 ns |      56.228 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace1_1** |       **replace21_1** |     **text50** |      **13.347 ns** |     **0.0253 ns** |     **0.0224 ns** |      **13.337 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |       replace21_1 |     text50 |      56.702 ns |     0.0850 ns |     0.0795 ns |      56.689 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace1_1** |       **replace21_1** |    **text100** |      **15.987 ns** |     **0.0509 ns** |     **0.0476 ns** |      **15.967 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace1_1 |       replace21_1 |    text100 |      60.461 ns |     0.1531 ns |     0.1432 ns |      60.408 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace1_1** |       **replace21_1** |    **text500** |     **136.788 ns** |     **1.3195 ns** |     **1.2343 ns** |     **137.162 ns** |  **0.2346** |       **-** |       **-** |    **1104 B** |
| RegexrReplace |       replace1_1 |       replace21_1 |    text500 |     361.886 ns |     1.5952 ns |     1.4921 ns |     361.865 ns |  0.2346 |       - |       - |    1104 B |
| **StringReplace** |       **replace1_1** |       **replace21_1** |  **text1_000** |     **233.440 ns** |     **2.0744 ns** |     **1.9404 ns** |     **234.578 ns** |  **0.4537** |       **-** |       **-** |    **2136 B** |
| RegexrReplace |       replace1_1 |       replace21_1 |  text1_000 |     480.943 ns |     2.9780 ns |     2.7856 ns |     481.823 ns |  0.4530 |       - |       - |    2136 B |
| **StringReplace** |       **replace1_1** |       **replace21_1** |  **text5_000** |     **859.339 ns** |     **5.1258 ns** |     **4.7947 ns** |     **859.685 ns** |  **2.1734** |       **-** |       **-** |   **10256 B** |
| RegexrReplace |       replace1_1 |       replace21_1 |  text5_000 |   1,260.211 ns |     3.6183 ns |     3.3846 ns |   1,260.100 ns |  2.1725 |       - |       - |   10256 B |
| **StringReplace** |       **replace1_1** |       **replace21_1** | **text10_000** |   **1,798.370 ns** |    **30.1774 ns** |    **26.7515 ns** |   **1,807.580 ns** |  **4.3087** |       **-** |       **-** |   **20328 B** |
| RegexrReplace |       replace1_1 |       replace21_1 | text10_000 |   2,322.159 ns |    19.6788 ns |    18.4076 ns |   2,322.157 ns |  4.3068 |       - |       - |   20328 B |
| **StringReplace** |       **replace1_1** |       **replace21_1** | **text50_000** |  **31,573.885 ns** |   **181.1109 ns** |   **160.5501 ns** |  **31,560.193 ns** | **32.2266** | **32.2266** | **32.2266** |  **101635 B** |
| RegexrReplace |       replace1_1 |       replace21_1 | text50_000 |  35,543.221 ns |   295.1416 ns |   276.0756 ns |  35,540.900 ns | 32.2266 | 32.2266 | 32.2266 |  101646 B |
| **StringReplace** |       **replace2_1** |        **replace1_1** |     **text10** |      **11.202 ns** |     **0.0148 ns** |     **0.0138 ns** |      **11.198 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace2_1 |        replace1_1 |     text10 |      53.767 ns |     0.4175 ns |     0.3906 ns |      53.968 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace2_1** |        **replace1_1** |     **text50** |      **15.347 ns** |     **0.0495 ns** |     **0.0463 ns** |      **15.334 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace2_1 |        replace1_1 |     text50 |      82.453 ns |     0.2174 ns |     0.2034 ns |      82.345 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace2_1** |        **replace1_1** |    **text100** |      **17.146 ns** |     **0.2403 ns** |     **0.2248 ns** |      **17.043 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace2_1 |        replace1_1 |    text100 |     124.785 ns |     0.3728 ns |     0.3305 ns |     124.706 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace2_1** |        **replace1_1** |    **text500** |     **145.177 ns** |     **0.1374 ns** |     **0.1285 ns** |     **145.191 ns** |  **0.2174** |       **-** |       **-** |    **1024 B** |
| RegexrReplace |       replace2_1 |        replace1_1 |    text500 |     742.611 ns |     1.4586 ns |     1.3644 ns |     742.520 ns |  0.2174 |       - |       - |    1024 B |
| **StringReplace** |       **replace2_1** |        **replace1_1** |  **text1_000** |     **245.534 ns** |     **1.2361 ns** |     **1.0958 ns** |     **245.817 ns** |  **0.4282** |       **-** |       **-** |    **2016 B** |
| RegexrReplace |       replace2_1 |        replace1_1 |  text1_000 |   1,294.637 ns |     4.6430 ns |     4.1159 ns |   1,294.483 ns |  0.4272 |       - |       - |    2016 B |
| **StringReplace** |       **replace2_1** |        **replace1_1** |  **text5_000** |     **995.221 ns** |     **0.8772 ns** |     **0.8206 ns** |     **995.209 ns** |  **2.1229** |       **-** |       **-** |   **10000 B** |
| RegexrReplace |       replace2_1 |        replace1_1 |  text5_000 |   5,942.855 ns |    24.5745 ns |    22.9870 ns |   5,938.496 ns |  2.1210 |       - |       - |   10000 B |
| **StringReplace** |       **replace2_1** |        **replace1_1** | **text10_000** |   **2,120.719 ns** |    **17.5440 ns** |    **16.4106 ns** |   **2,124.033 ns** |  **4.2343** |       **-** |       **-** |   **19976 B** |
| RegexrReplace |       replace2_1 |        replace1_1 | text10_000 |  17,912.054 ns |    70.9475 ns |    66.3643 ns |  17,899.463 ns |  4.2114 |       - |       - |   19976 B |
| **StringReplace** |       **replace2_1** |        **replace1_1** | **text50_000** |  **33,111.595 ns** |   **269.1588 ns** |   **251.7713 ns** |  **33,098.511 ns** | **31.1890** | **31.1890** | **31.1890** |   **99803 B** |
| RegexrReplace |       replace2_1 |        replace1_1 | text50_000 | 133,852.201 ns |   407.2326 ns |   380.9257 ns | 133,911.670 ns | 31.0059 | 31.0059 | 31.0059 |   99813 B |
| **StringReplace** |       **replace2_1** |        **replace2_1** |     **text10** |      **11.184 ns** |     **0.0265 ns** |     **0.0221 ns** |      **11.174 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace2_1 |        replace2_1 |     text10 |      50.220 ns |     0.1933 ns |     0.1809 ns |      50.183 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace2_1** |        **replace2_1** |     **text50** |      **15.565 ns** |     **0.0620 ns** |     **0.0580 ns** |      **15.550 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace2_1 |        replace2_1 |     text50 |      81.363 ns |     0.2616 ns |     0.2319 ns |      81.274 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace2_1** |        **replace2_1** |    **text100** |      **16.976 ns** |     **0.0461 ns** |     **0.0431 ns** |      **16.951 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace2_1 |        replace2_1 |    text100 |     124.449 ns |     0.3784 ns |     0.3540 ns |     124.416 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace2_1** |        **replace2_1** |    **text500** |     **144.071 ns** |     **0.5336 ns** |     **0.4991 ns** |     **144.206 ns** |  **0.2174** |       **-** |       **-** |    **1024 B** |
| RegexrReplace |       replace2_1 |        replace2_1 |    text500 |     754.068 ns |     2.4725 ns |     2.3128 ns |     754.679 ns |  0.2174 |       - |       - |    1024 B |
| **StringReplace** |       **replace2_1** |        **replace2_1** |  **text1_000** |     **245.665 ns** |     **0.3897 ns** |     **0.3645 ns** |     **245.584 ns** |  **0.4301** |       **-** |       **-** |    **2024 B** |
| RegexrReplace |       replace2_1 |        replace2_1 |  text1_000 |   1,295.983 ns |     2.8196 ns |     2.6375 ns |   1,295.089 ns |  0.4292 |       - |       - |    2024 B |
| **StringReplace** |       **replace2_1** |        **replace2_1** |  **text5_000** |     **979.408 ns** |    **11.0719 ns** |    **10.3566 ns** |     **986.915 ns** |  **2.1267** |       **-** |       **-** |   **10024 B** |
| RegexrReplace |       replace2_1 |        replace2_1 |  text5_000 |   5,960.575 ns |    26.5710 ns |    23.5545 ns |   5,954.659 ns |  2.1210 |       - |       - |   10024 B |
| **StringReplace** |       **replace2_1** |        **replace2_1** | **text10_000** |   **2,144.036 ns** |     **8.7085 ns** |     **7.2720 ns** |   **2,144.340 ns** |  **4.2343** |       **-** |       **-** |   **20024 B** |
| RegexrReplace |       replace2_1 |        replace2_1 | text10_000 |  17,973.094 ns |    52.6112 ns |    46.6384 ns |  17,971.483 ns |  4.2114 |       - |       - |   20024 B |
| **StringReplace** |       **replace2_1** |        **replace2_1** | **text50_000** |  **32,956.379 ns** |   **286.4419 ns** |   **267.9379 ns** |  **32,958.002 ns** | **31.1890** | **31.1890** | **31.1890** |  **100035 B** |
| RegexrReplace |       replace2_1 |        replace2_1 | text50_000 | 133,520.213 ns |   326.5836 ns |   305.4865 ns | 133,500.146 ns | 31.0059 | 31.0059 | 31.0059 |  100045 B |
| **StringReplace** |       **replace2_1** |        **replace3_1** |     **text10** |      **11.218 ns** |     **0.0354 ns** |     **0.0331 ns** |      **11.218 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace2_1 |        replace3_1 |     text10 |      54.199 ns |     0.1269 ns |     0.1187 ns |      54.198 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace2_1** |        **replace3_1** |     **text50** |      **15.343 ns** |     **0.0476 ns** |     **0.0445 ns** |      **15.331 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace2_1 |        replace3_1 |     text50 |      78.924 ns |     0.1482 ns |     0.1157 ns |      78.963 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace2_1** |        **replace3_1** |    **text100** |      **16.823 ns** |     **0.0314 ns** |     **0.0294 ns** |      **16.820 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace2_1 |        replace3_1 |    text100 |     123.313 ns |     1.0067 ns |     0.8924 ns |     122.935 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace2_1** |        **replace3_1** |    **text500** |     **143.562 ns** |     **1.1944 ns** |     **1.1173 ns** |     **143.203 ns** |  **0.2193** |       **-** |       **-** |    **1032 B** |
| RegexrReplace |       replace2_1 |        replace3_1 |    text500 |     740.606 ns |     1.1275 ns |     0.9995 ns |     740.391 ns |  0.2193 |       - |       - |    1032 B |
| **StringReplace** |       **replace2_1** |        **replace3_1** |  **text1_000** |     **245.272 ns** |     **1.1063 ns** |     **1.0349 ns** |     **245.325 ns** |  **0.4315** |       **-** |       **-** |    **2032 B** |
| RegexrReplace |       replace2_1 |        replace3_1 |  text1_000 |   1,313.163 ns |     3.4814 ns |     3.2565 ns |   1,313.455 ns |  0.4311 |       - |       - |    2032 B |
| **StringReplace** |       **replace2_1** |        **replace3_1** |  **text5_000** |     **980.680 ns** |     **0.7911 ns** |     **0.7013 ns** |     **980.706 ns** |  **2.1305** |       **-** |       **-** |   **10048 B** |
| RegexrReplace |       replace2_1 |        replace3_1 |  text5_000 |   6,015.137 ns |    32.3222 ns |    30.2342 ns |   6,009.578 ns |  2.1286 |       - |       - |   10048 B |
| **StringReplace** |       **replace2_1** |        **replace3_1** | **text10_000** |   **2,142.989 ns** |    **13.4031 ns** |    **10.4643 ns** |   **2,146.081 ns** |  **4.2534** |       **-** |       **-** |   **20072 B** |
| RegexrReplace |       replace2_1 |        replace3_1 | text10_000 |  17,977.416 ns |    49.0489 ns |    45.8803 ns |  17,973.358 ns |  4.2419 |       - |       - |   20072 B |
| **StringReplace** |       **replace2_1** |        **replace3_1** | **text50_000** |  **33,029.315 ns** |   **207.9368 ns** |   **184.3306 ns** |  **33,078.259 ns** | **31.1890** | **31.1890** | **31.1890** |  **100267 B** |
| RegexrReplace |       replace2_1 |        replace3_1 | text50_000 | 134,427.783 ns |   826.8774 ns |   773.4617 ns | 134,435.938 ns | 31.0059 | 31.0059 | 31.0059 |  100277 B |
| **StringReplace** |       **replace2_1** |        **replace5_1** |     **text10** |      **11.227 ns** |     **0.0283 ns** |     **0.0251 ns** |      **11.232 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace2_1 |        replace5_1 |     text10 |      50.202 ns |     0.1824 ns |     0.1617 ns |      50.146 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace2_1** |        **replace5_1** |     **text50** |      **15.316 ns** |     **0.0334 ns** |     **0.0261 ns** |      **15.328 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace2_1 |        replace5_1 |     text50 |      76.206 ns |     0.2194 ns |     0.2052 ns |      76.186 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace2_1** |        **replace5_1** |    **text100** |      **16.804 ns** |     **0.0184 ns** |     **0.0143 ns** |      **16.804 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace2_1 |        replace5_1 |    text100 |     122.849 ns |     0.4214 ns |     0.3942 ns |     122.780 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace2_1** |        **replace5_1** |    **text500** |     **145.671 ns** |     **0.9512 ns** |     **0.8897 ns** |     **146.119 ns** |  **0.2210** |       **-** |       **-** |    **1040 B** |
| RegexrReplace |       replace2_1 |        replace5_1 |    text500 |     745.779 ns |     2.8879 ns |     2.7013 ns |     745.992 ns |  0.2203 |       - |       - |    1040 B |
| **StringReplace** |       **replace2_1** |        **replace5_1** |  **text1_000** |     **244.223 ns** |     **1.5422 ns** |     **1.4426 ns** |     **244.075 ns** |  **0.4334** |       **-** |       **-** |    **2040 B** |
| RegexrReplace |       replace2_1 |        replace5_1 |  text1_000 |   1,312.206 ns |     3.6502 ns |     3.4144 ns |   1,311.913 ns |  0.4330 |       - |       - |    2040 B |
| **StringReplace** |       **replace2_1** |        **replace5_1** |  **text5_000** |     **995.137 ns** |     **2.0640 ns** |     **1.8297 ns** |     **994.406 ns** |  **2.1400** |       **-** |       **-** |   **10088 B** |
| RegexrReplace |       replace2_1 |        replace5_1 |  text5_000 |   5,948.645 ns |    19.9943 ns |    17.7244 ns |   5,947.900 ns |  2.1362 |       - |       - |   10088 B |
| **StringReplace** |       **replace2_1** |        **replace5_1** | **text10_000** |   **2,158.281 ns** |    **19.1255 ns** |    **15.9707 ns** |   **2,159.648 ns** |  **4.2725** |       **-** |       **-** |   **20176 B** |
| RegexrReplace |       replace2_1 |        replace5_1 | text10_000 |  17,926.464 ns |    67.6697 ns |    63.2983 ns |  17,937.677 ns |  4.2725 |       - |       - |   20176 B |
| **StringReplace** |       **replace2_1** |        **replace5_1** | **text50_000** |  **33,313.885 ns** |   **295.1920 ns** |   **276.1228 ns** |  **33,324.146 ns** | **31.1890** | **31.1890** | **31.1890** |  **100723 B** |
| RegexrReplace |       replace2_1 |        replace5_1 | text50_000 | 134,452.839 ns |   487.8274 ns |   456.3140 ns | 134,417.773 ns | 31.0059 | 31.0059 | 31.0059 |  100733 B |
| **StringReplace** |       **replace2_1** |        **replace8_1** |     **text10** |      **11.205 ns** |     **0.0205 ns** |     **0.0182 ns** |      **11.204 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace2_1 |        replace8_1 |     text10 |      50.156 ns |     0.0951 ns |     0.0742 ns |      50.184 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace2_1** |        **replace8_1** |     **text50** |      **15.321 ns** |     **0.0321 ns** |     **0.0268 ns** |      **15.325 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace2_1 |        replace8_1 |     text50 |      80.940 ns |     0.2094 ns |     0.1958 ns |      80.941 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace2_1** |        **replace8_1** |    **text100** |      **16.814 ns** |     **0.0412 ns** |     **0.0386 ns** |      **16.818 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace2_1 |        replace8_1 |    text100 |     122.881 ns |     0.2347 ns |     0.1960 ns |     122.897 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace2_1** |        **replace8_1** |    **text500** |     **147.188 ns** |     **0.1850 ns** |     **0.1640 ns** |     **147.153 ns** |  **0.2227** |       **-** |       **-** |    **1048 B** |
| RegexrReplace |       replace2_1 |        replace8_1 |    text500 |     768.526 ns |     1.2879 ns |     1.1417 ns |     768.424 ns |  0.2222 |       - |       - |    1048 B |
| **StringReplace** |       **replace2_1** |        **replace8_1** |  **text1_000** |     **244.477 ns** |     **2.9068 ns** |     **2.7190 ns** |     **246.433 ns** |  **0.4368** |       **-** |       **-** |    **2056 B** |
| RegexrReplace |       replace2_1 |        replace8_1 |  text1_000 |   1,300.666 ns |     3.3903 ns |     3.0054 ns |   1,301.346 ns |  0.4368 |       - |       - |    2056 B |
| **StringReplace** |       **replace2_1** |        **replace8_1** |  **text5_000** |   **1,004.941 ns** |     **7.5258 ns** |     **7.0396 ns** |   **1,007.570 ns** |  **2.1496** |       **-** |       **-** |   **10136 B** |
| RegexrReplace |       replace2_1 |        replace8_1 |  text5_000 |   5,943.749 ns |    24.9937 ns |    23.3791 ns |   5,948.851 ns |  2.1439 |       - |       - |   10136 B |
| **StringReplace** |       **replace2_1** |        **replace8_1** | **text10_000** |   **2,145.059 ns** |    **19.6780 ns** |    **17.4440 ns** |   **2,143.757 ns** |  **4.2915** |       **-** |       **-** |   **20272 B** |
| RegexrReplace |       replace2_1 |        replace8_1 | text10_000 |  17,906.435 ns |    59.0455 ns |    55.2312 ns |  17,920.197 ns |  4.2725 |       - |       - |   20272 B |
| **StringReplace** |       **replace2_1** |        **replace8_1** | **text50_000** |  **33,567.759 ns** |   **275.1745 ns** |   **257.3984 ns** |  **33,523.547 ns** | **31.1890** | **31.1890** | **31.1890** |  **101187 B** |
| RegexrReplace |       replace2_1 |        replace8_1 | text50_000 | 133,910.699 ns |   241.9942 ns |   202.0761 ns | 133,965.259 ns | 31.0059 | 31.0059 | 31.0059 |  101197 B |
| **StringReplace** |       **replace2_1** |       **replace13_1** |     **text10** |      **11.176 ns** |     **0.0162 ns** |     **0.0144 ns** |      **11.176 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace2_1 |       replace13_1 |     text10 |      50.674 ns |     0.0739 ns |     0.0655 ns |      50.660 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace2_1** |       **replace13_1** |     **text50** |      **15.696 ns** |     **0.0777 ns** |     **0.0649 ns** |      **15.682 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace2_1 |       replace13_1 |     text50 |      79.798 ns |     0.4267 ns |     0.3991 ns |      79.788 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace2_1** |       **replace13_1** |    **text100** |      **16.835 ns** |     **0.0596 ns** |     **0.0558 ns** |      **16.816 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace2_1 |       replace13_1 |    text100 |     126.081 ns |     0.9533 ns |     0.8917 ns |     125.907 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace2_1** |       **replace13_1** |    **text500** |     **145.778 ns** |     **0.8588 ns** |     **0.7613 ns** |     **146.111 ns** |  **0.2260** |       **-** |       **-** |    **1064 B** |
| RegexrReplace |       replace2_1 |       replace13_1 |    text500 |     738.800 ns |     2.3234 ns |     2.1733 ns |     738.431 ns |  0.2260 |       - |       - |    1064 B |
| **StringReplace** |       **replace2_1** |       **replace13_1** |  **text1_000** |     **249.437 ns** |     **1.5546 ns** |     **1.2982 ns** |     **249.527 ns** |  **0.4435** |       **-** |       **-** |    **2088 B** |
| RegexrReplace |       replace2_1 |       replace13_1 |  text1_000 |   1,304.243 ns |     4.9043 ns |     4.0953 ns |   1,303.504 ns |  0.4425 |       - |       - |    2088 B |
| **StringReplace** |       **replace2_1** |       **replace13_1** |  **text5_000** |     **999.445 ns** |     **5.4325 ns** |     **4.5364 ns** |     **998.580 ns** |  **2.1725** |       **-** |       **-** |   **10248 B** |
| RegexrReplace |       replace2_1 |       replace13_1 |  text5_000 |   6,019.226 ns |    48.8456 ns |    43.3004 ns |   6,005.717 ns |  2.1667 |       - |       - |   10248 B |
| **StringReplace** |       **replace2_1** |       **replace13_1** | **text10_000** |   **2,187.940 ns** |    **11.8853 ns** |    **11.1175 ns** |   **2,190.229 ns** |  **4.3449** |       **-** |       **-** |   **20528 B** |
| RegexrReplace |       replace2_1 |       replace13_1 | text10_000 |  18,081.158 ns |   112.1593 ns |    99.4263 ns |  18,051.857 ns |  4.3335 |       - |       - |   20528 B |
| **StringReplace** |       **replace2_1** |       **replace13_1** | **text50_000** |  **33,413.836 ns** |   **258.0455 ns** |   **241.3759 ns** |  **33,410.779 ns** | **32.2266** | **32.2266** | **32.2266** |  **102339 B** |
| RegexrReplace |       replace2_1 |       replace13_1 | text50_000 | 134,763.867 ns |   611.2694 ns |   541.8744 ns | 134,683.398 ns | 32.2266 | 32.2266 | 32.2266 |  102350 B |
| **StringReplace** |       **replace2_1** |       **replace21_1** |     **text10** |      **11.186 ns** |     **0.0200 ns** |     **0.0177 ns** |      **11.186 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace2_1 |       replace21_1 |     text10 |      58.183 ns |     0.0863 ns |     0.0765 ns |      58.155 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace2_1** |       **replace21_1** |     **text50** |      **15.312 ns** |     **0.0352 ns** |     **0.0275 ns** |      **15.326 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace2_1 |       replace21_1 |     text50 |      76.362 ns |     0.2036 ns |     0.1805 ns |      76.328 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace2_1** |       **replace21_1** |    **text100** |      **16.818 ns** |     **0.0433 ns** |     **0.0405 ns** |      **16.813 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace2_1 |       replace21_1 |    text100 |     126.080 ns |     0.3791 ns |     0.3546 ns |     126.057 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace2_1** |       **replace21_1** |    **text500** |     **147.410 ns** |     **1.0486 ns** |     **0.9809 ns** |     **147.976 ns** |  **0.2329** |       **-** |       **-** |    **1096 B** |
| RegexrReplace |       replace2_1 |       replace21_1 |    text500 |     743.351 ns |     1.5280 ns |     1.2760 ns |     743.650 ns |  0.2327 |       - |       - |    1096 B |
| **StringReplace** |       **replace2_1** |       **replace21_1** |  **text1_000** |     **250.153 ns** |     **1.3723 ns** |     **1.2837 ns** |     **250.499 ns** |  **0.4535** |       **-** |       **-** |    **2136 B** |
| RegexrReplace |       replace2_1 |       replace21_1 |  text1_000 |   1,296.018 ns |     3.9319 ns |     3.6779 ns |   1,295.294 ns |  0.4520 |       - |       - |    2136 B |
| **StringReplace** |       **replace2_1** |       **replace21_1** |  **text5_000** |   **1,013.425 ns** |     **0.7710 ns** |     **0.6834 ns** |   **1,013.283 ns** |  **2.2106** |       **-** |       **-** |   **10424 B** |
| RegexrReplace |       replace2_1 |       replace21_1 |  text5_000 |   5,990.380 ns |    13.6566 ns |    12.7744 ns |   5,987.972 ns |  2.2049 |       - |       - |   10424 B |
| **StringReplace** |       **replace2_1** |       **replace21_1** | **text10_000** |   **2,219.771 ns** |     **1.4174 ns** |     **1.2565 ns** |   **2,220.019 ns** |  **4.4212** |       **-** |       **-** |   **20928 B** |
| RegexrReplace |       replace2_1 |       replace21_1 | text10_000 |  18,135.102 ns |    62.9506 ns |    58.8841 ns |  18,146.933 ns |  4.4250 |       - |       - |   20928 B |
| **StringReplace** |       **replace2_1** |       **replace21_1** | **text50_000** |  **35,265.883 ns** |   **273.2464 ns** |   **242.2258 ns** |  **35,294.247 ns** | **32.2266** | **32.2266** | **32.2266** |  **104179 B** |
| RegexrReplace |       replace2_1 |       replace21_1 | text50_000 | 136,933.805 ns |   335.6338 ns |   313.9521 ns | 137,065.088 ns | 32.2266 | 32.2266 | 32.2266 |  104190 B |
| **StringReplace** |       **replace3_1** |        **replace1_1** |     **text10** |      **10.957 ns** |     **0.0216 ns** |     **0.0191 ns** |      **10.959 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace3_1 |        replace1_1 |     text10 |      53.218 ns |     0.3123 ns |     0.2921 ns |      53.314 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace3_1** |        **replace1_1** |     **text50** |      **15.150 ns** |     **0.0586 ns** |     **0.0548 ns** |      **15.133 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace3_1 |        replace1_1 |     text50 |      61.096 ns |     0.0831 ns |     0.0694 ns |      61.099 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace3_1** |        **replace1_1** |    **text100** |      **15.458 ns** |     **0.0239 ns** |     **0.0200 ns** |      **15.460 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace3_1 |        replace1_1 |    text100 |      81.379 ns |     0.2210 ns |     0.1846 ns |      81.376 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace3_1** |        **replace1_1** |    **text500** |     **163.294 ns** |     **0.9901 ns** |     **0.9262 ns** |     **162.588 ns** |  **0.2158** |       **-** |       **-** |    **1016 B** |
| RegexrReplace |       replace3_1 |        replace1_1 |    text500 |     550.316 ns |     1.6710 ns |     1.5631 ns |     549.854 ns |  0.2155 |       - |       - |    1016 B |
| **StringReplace** |       **replace3_1** |        **replace1_1** |  **text1_000** |     **263.536 ns** |     **1.9235 ns** |     **1.7992 ns** |     **264.439 ns** |  **0.4263** |       **-** |       **-** |    **2008 B** |
| RegexrReplace |       replace3_1 |        replace1_1 |  text1_000 |     883.304 ns |     3.8978 ns |     3.6460 ns |     882.675 ns |  0.4263 |       - |       - |    2008 B |
| **StringReplace** |       **replace3_1** |        **replace1_1** |  **text5_000** |   **1,109.514 ns** |     **3.0003 ns** |     **2.5054 ns** |   **1,108.692 ns** |  **2.1133** |       **-** |       **-** |    **9960 B** |
| RegexrReplace |       replace3_1 |        replace1_1 |  text5_000 |   3,591.127 ns |    21.1209 ns |    18.7231 ns |   3,593.775 ns |  2.1133 |       - |       - |    9960 B |
| **StringReplace** |       **replace3_1** |        **replace1_1** | **text10_000** |   **2,238.938 ns** |    **27.8676 ns** |    **26.0674 ns** |   **2,252.388 ns** |  **4.2191** |       **-** |       **-** |   **19912 B** |
| RegexrReplace |       replace3_1 |        replace1_1 | text10_000 |   7,018.696 ns |    36.8858 ns |    34.5030 ns |   7,021.460 ns |  4.2191 |       - |       - |   19912 B |
| **StringReplace** |       **replace3_1** |        **replace1_1** | **text50_000** |  **34,096.669 ns** |   **275.8752 ns** |   **258.0539 ns** |  **34,003.876 ns** | **31.1890** | **31.1890** | **31.1890** |   **99509 B** |
| RegexrReplace |       replace3_1 |        replace1_1 | text50_000 |  67,512.920 ns |   177.8686 ns |   166.3784 ns |  67,478.284 ns | 31.1279 | 31.1279 | 31.1279 |   99509 B |
| **StringReplace** |       **replace3_1** |        **replace2_1** |     **text10** |      **10.942 ns** |     **0.0312 ns** |     **0.0276 ns** |      **10.942 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace3_1 |        replace2_1 |     text10 |      50.022 ns |     0.1033 ns |     0.0916 ns |      50.025 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace3_1** |        **replace2_1** |     **text50** |      **15.118 ns** |     **0.0463 ns** |     **0.0387 ns** |      **15.109 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace3_1 |        replace2_1 |     text50 |      70.620 ns |     0.1615 ns |     0.1261 ns |      70.654 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace3_1** |        **replace2_1** |    **text100** |      **15.475 ns** |     **0.0314 ns** |     **0.0279 ns** |      **15.473 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace3_1 |        replace2_1 |    text100 |      87.918 ns |     0.1521 ns |     0.1348 ns |      87.897 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace3_1** |        **replace2_1** |    **text500** |     **161.948 ns** |     **0.7252 ns** |     **0.6429 ns** |     **161.950 ns** |  **0.2158** |       **-** |       **-** |    **1016 B** |
| RegexrReplace |       replace3_1 |        replace2_1 |    text500 |     569.319 ns |     1.8974 ns |     1.7748 ns |     569.365 ns |  0.2155 |       - |       - |    1016 B |
| **StringReplace** |       **replace3_1** |        **replace2_1** |  **text1_000** |     **263.671 ns** |     **0.7932 ns** |     **0.7031 ns** |     **263.930 ns** |  **0.4282** |       **-** |       **-** |    **2016 B** |
| RegexrReplace |       replace3_1 |        replace2_1 |  text1_000 |     912.698 ns |     6.1294 ns |     5.7335 ns |     914.107 ns |  0.4282 |       - |       - |    2016 B |
| **StringReplace** |       **replace3_1** |        **replace2_1** |  **text5_000** |   **1,127.238 ns** |     **8.8371 ns** |     **6.8994 ns** |   **1,130.232 ns** |  **2.1172** |       **-** |       **-** |    **9992 B** |
| RegexrReplace |       replace3_1 |        replace2_1 |  text5_000 |   3,582.075 ns |    16.9284 ns |    15.8348 ns |   3,581.100 ns |  2.1172 |       - |       - |    9992 B |
| **StringReplace** |       **replace3_1** |        **replace2_1** | **text10_000** |   **2,247.049 ns** |     **9.8146 ns** |     **8.7004 ns** |   **2,249.852 ns** |  **4.2191** |       **-** |       **-** |   **19968 B** |
| RegexrReplace |       replace3_1 |        replace2_1 | text10_000 |   7,083.042 ns |    34.4997 ns |    32.2710 ns |   7,072.758 ns |  4.2191 |       - |       - |   19968 B |
| **StringReplace** |       **replace3_1** |        **replace2_1** | **text50_000** |  **34,583.280 ns** |   **255.9759 ns** |   **239.4400 ns** |  **34,561.780 ns** | **31.1890** | **31.1890** | **31.1890** |   **99781 B** |
| RegexrReplace |       replace3_1 |        replace2_1 | text50_000 |  67,655.885 ns |   198.0415 ns |   185.2481 ns |  67,716.711 ns | 31.1279 | 31.1279 | 31.1279 |   99781 B |
| **StringReplace** |       **replace3_1** |        **replace3_1** |     **text10** |      **10.953 ns** |     **0.0140 ns** |     **0.0117 ns** |      **10.950 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace3_1 |        replace3_1 |     text10 |      53.850 ns |     0.0846 ns |     0.0791 ns |      53.809 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace3_1** |        **replace3_1** |     **text50** |      **15.116 ns** |     **0.0086 ns** |     **0.0072 ns** |      **15.115 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace3_1 |        replace3_1 |     text50 |      68.578 ns |     0.9691 ns |     0.9065 ns |      68.224 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace3_1** |        **replace3_1** |    **text100** |      **15.538 ns** |     **0.0453 ns** |     **0.0402 ns** |      **15.544 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace3_1 |        replace3_1 |    text100 |      82.905 ns |     1.6732 ns |     2.5551 ns |      81.251 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace3_1** |        **replace3_1** |    **text500** |     **162.825 ns** |     **1.1391 ns** |     **1.0655 ns** |     **163.188 ns** |  **0.2174** |       **-** |       **-** |    **1024 B** |
| RegexrReplace |       replace3_1 |        replace3_1 |    text500 |     557.856 ns |     1.7439 ns |     1.6312 ns |     558.201 ns |  0.2174 |       - |       - |    1024 B |
| **StringReplace** |       **replace3_1** |        **replace3_1** |  **text1_000** |     **265.708 ns** |     **1.0927 ns** |     **1.0221 ns** |     **266.055 ns** |  **0.4301** |       **-** |       **-** |    **2024 B** |
| RegexrReplace |       replace3_1 |        replace3_1 |  text1_000 |     882.477 ns |     3.1814 ns |     2.8203 ns |     883.084 ns |  0.4301 |       - |       - |    2024 B |
| **StringReplace** |       **replace3_1** |        **replace3_1** |  **text5_000** |   **1,134.465 ns** |     **4.2918 ns** |     **4.0146 ns** |   **1,134.241 ns** |  **2.1267** |       **-** |       **-** |   **10024 B** |
| RegexrReplace |       replace3_1 |        replace3_1 |  text5_000 |   3,549.198 ns |    13.8657 ns |    12.2916 ns |   3,547.407 ns |  2.1248 |       - |       - |   10024 B |
| **StringReplace** |       **replace3_1** |        **replace3_1** | **text10_000** |   **2,274.202 ns** |    **13.0755 ns** |    **12.2308 ns** |   **2,271.994 ns** |  **4.2343** |       **-** |       **-** |   **20024 B** |
| RegexrReplace |       replace3_1 |        replace3_1 | text10_000 |   7,100.512 ns |    31.9676 ns |    29.9025 ns |   7,111.155 ns |  4.2343 |       - |       - |   20024 B |
| **StringReplace** |       **replace3_1** |        **replace3_1** | **text50_000** |  **34,704.041 ns** |   **237.0326 ns** |   **210.1232 ns** |  **34,698.990 ns** | **31.1890** | **31.1890** | **31.1890** |  **100045 B** |
| RegexrReplace |       replace3_1 |        replace3_1 | text50_000 |  67,874.966 ns |   197.2085 ns |   184.4689 ns |  67,846.729 ns | 31.1279 | 31.1279 | 31.1279 |  100045 B |
| **StringReplace** |       **replace3_1** |        **replace5_1** |     **text10** |      **10.957 ns** |     **0.0233 ns** |     **0.0194 ns** |      **10.954 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace3_1 |        replace5_1 |     text10 |      52.618 ns |     0.4436 ns |     0.3464 ns |      52.729 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace3_1** |        **replace5_1** |     **text50** |      **15.100 ns** |     **0.0332 ns** |     **0.0259 ns** |      **15.111 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace3_1 |        replace5_1 |     text50 |      70.108 ns |     0.1493 ns |     0.1247 ns |      70.099 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace3_1** |        **replace5_1** |    **text100** |      **15.496 ns** |     **0.0280 ns** |     **0.0219 ns** |      **15.495 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace3_1 |        replace5_1 |    text100 |      89.663 ns |     0.2444 ns |     0.2286 ns |      89.521 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace3_1** |        **replace5_1** |    **text500** |     **163.332 ns** |     **0.6950 ns** |     **0.6501 ns** |     **163.528 ns** |  **0.2210** |       **-** |       **-** |    **1040 B** |
| RegexrReplace |       replace3_1 |        replace5_1 |    text500 |     548.971 ns |     1.7944 ns |     1.6784 ns |     548.807 ns |  0.2203 |       - |       - |    1040 B |
| **StringReplace** |       **replace3_1** |        **replace5_1** |  **text1_000** |     **265.120 ns** |     **1.7582 ns** |     **1.6446 ns** |     **265.670 ns** |  **0.4334** |       **-** |       **-** |    **2040 B** |
| RegexrReplace |       replace3_1 |        replace5_1 |  text1_000 |     887.640 ns |     2.4539 ns |     2.1753 ns |     887.386 ns |  0.4330 |       - |       - |    2040 B |
| **StringReplace** |       **replace3_1** |        **replace5_1** |  **text5_000** |   **1,135.471 ns** |     **8.8618 ns** |     **8.2894 ns** |   **1,139.636 ns** |  **2.1400** |       **-** |       **-** |   **10088 B** |
| RegexrReplace |       replace3_1 |        replace5_1 |  text5_000 |   3,557.253 ns |    12.0481 ns |    11.2698 ns |   3,554.496 ns |  2.1400 |       - |       - |   10088 B |
| **StringReplace** |       **replace3_1** |        **replace5_1** | **text10_000** |   **2,269.211 ns** |     **2.6159 ns** |     **2.3189 ns** |   **2,269.446 ns** |  **4.2725** |       **-** |       **-** |   **20144 B** |
| RegexrReplace |       replace3_1 |        replace5_1 | text10_000 |   7,061.694 ns |    30.3815 ns |    28.4189 ns |   7,062.489 ns |  4.2725 |       - |       - |   20144 B |
| **StringReplace** |       **replace3_1** |        **replace5_1** | **text50_000** |  **34,416.717 ns** |   **266.9856 ns** |   **249.7385 ns** |  **34,458.588 ns** | **31.1890** | **31.1890** | **31.1890** |  **100581 B** |
| RegexrReplace |       replace3_1 |        replace5_1 | text50_000 |  67,580.884 ns |   177.0910 ns |   156.9866 ns |  67,593.597 ns | 31.1279 | 31.1279 | 31.1279 |  100581 B |
| **StringReplace** |       **replace3_1** |        **replace8_1** |     **text10** |      **11.059 ns** |     **0.0375 ns** |     **0.0333 ns** |      **11.053 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace3_1 |        replace8_1 |     text10 |      52.858 ns |     0.1252 ns |     0.1110 ns |      52.820 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace3_1** |        **replace8_1** |     **text50** |      **15.162 ns** |     **0.0120 ns** |     **0.0093 ns** |      **15.159 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace3_1 |        replace8_1 |     text50 |      66.225 ns |     0.1549 ns |     0.1294 ns |      66.200 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace3_1** |        **replace8_1** |    **text100** |      **15.506 ns** |     **0.0265 ns** |     **0.0207 ns** |      **15.509 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace3_1 |        replace8_1 |    text100 |      86.073 ns |     0.1630 ns |     0.1525 ns |      86.048 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace3_1** |        **replace8_1** |    **text500** |     **163.856 ns** |     **0.9668 ns** |     **0.9044 ns** |     **164.201 ns** |  **0.2227** |       **-** |       **-** |    **1048 B** |
| RegexrReplace |       replace3_1 |        replace8_1 |    text500 |     549.915 ns |     2.4134 ns |     2.2575 ns |     549.765 ns |  0.2222 |       - |       - |    1048 B |
| **StringReplace** |       **replace3_1** |        **replace8_1** |  **text1_000** |     **263.856 ns** |     **2.4431 ns** |     **2.2853 ns** |     **265.578 ns** |  **0.4368** |       **-** |       **-** |    **2056 B** |
| RegexrReplace |       replace3_1 |        replace8_1 |  text1_000 |     879.903 ns |     1.8339 ns |     1.5314 ns |     880.033 ns |  0.4368 |       - |       - |    2056 B |
| **StringReplace** |       **replace3_1** |        **replace8_1** |  **text5_000** |   **1,132.587 ns** |     **0.8418 ns** |     **0.7029 ns** |   **1,132.632 ns** |  **2.1534** |       **-** |       **-** |   **10152 B** |
| RegexrReplace |       replace3_1 |        replace8_1 |  text5_000 |   3,588.115 ns |    10.5319 ns |     9.3362 ns |   3,585.643 ns |  2.1515 |       - |       - |   10152 B |
| **StringReplace** |       **replace3_1** |        **replace8_1** | **text10_000** |   **2,301.293 ns** |    **12.9078 ns** |    **12.0739 ns** |   **2,302.045 ns** |  **4.2915** |       **-** |       **-** |   **20256 B** |
| RegexrReplace |       replace3_1 |        replace8_1 | text10_000 |   7,097.318 ns |    27.2529 ns |    24.1590 ns |   7,095.926 ns |  4.2877 |       - |       - |   20256 B |
| **StringReplace** |       **replace3_1** |        **replace8_1** | **text50_000** |  **34,434.838 ns** |   **266.5109 ns** |   **249.2945 ns** |  **34,420.557 ns** | **31.1890** | **31.1890** | **31.1890** |  **101117 B** |
| RegexrReplace |       replace3_1 |        replace8_1 | text50_000 |  67,568.589 ns |   182.4553 ns |   152.3584 ns |  67,597.424 ns | 31.1279 | 31.1279 | 31.1279 |  101117 B |
| **StringReplace** |       **replace3_1** |       **replace13_1** |     **text10** |      **10.970 ns** |     **0.0216 ns** |     **0.0202 ns** |      **10.970 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace3_1 |       replace13_1 |     text10 |      51.752 ns |     0.0651 ns |     0.0544 ns |      51.744 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace3_1** |       **replace13_1** |     **text50** |      **15.117 ns** |     **0.0372 ns** |     **0.0330 ns** |      **15.115 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace3_1 |       replace13_1 |     text50 |      60.422 ns |     0.1535 ns |     0.1199 ns |      60.387 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace3_1** |       **replace13_1** |    **text100** |      **15.570 ns** |     **0.0466 ns** |     **0.0413 ns** |      **15.570 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace3_1 |       replace13_1 |    text100 |      80.914 ns |     0.2377 ns |     0.2223 ns |      80.828 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace3_1** |       **replace13_1** |    **text500** |     **164.370 ns** |     **1.1603 ns** |     **1.0853 ns** |     **163.801 ns** |  **0.2294** |       **-** |       **-** |    **1080 B** |
| RegexrReplace |       replace3_1 |       replace13_1 |    text500 |     552.948 ns |     1.9400 ns |     1.8147 ns |     552.951 ns |  0.2289 |       - |       - |    1080 B |
| **StringReplace** |       **replace3_1** |       **replace13_1** |  **text1_000** |     **267.871 ns** |     **1.7792 ns** |     **1.6642 ns** |     **267.149 ns** |  **0.4454** |       **-** |       **-** |    **2096 B** |
| RegexrReplace |       replace3_1 |       replace13_1 |  text1_000 |     870.347 ns |     2.7990 ns |     2.6182 ns |     870.657 ns |  0.4454 |       - |       - |    2096 B |
| **StringReplace** |       **replace3_1** |       **replace13_1** |  **text5_000** |   **1,141.134 ns** |     **0.7801 ns** |     **0.7297 ns** |   **1,141.221 ns** |  **2.1877** |       **-** |       **-** |   **10312 B** |
| RegexrReplace |       replace3_1 |       replace13_1 |  text5_000 |   3,608.312 ns |    20.3806 ns |    19.0640 ns |   3,612.980 ns |  2.1858 |       - |       - |   10312 B |
| **StringReplace** |       **replace3_1** |       **replace13_1** | **text10_000** |   **2,339.691 ns** |     **2.1971 ns** |     **2.0552 ns** |   **2,339.632 ns** |  **4.3449** |       **-** |       **-** |   **20544 B** |
| RegexrReplace |       replace3_1 |       replace13_1 | text10_000 |   7,151.239 ns |    32.3989 ns |    28.7208 ns |   7,157.473 ns |  4.3411 |       - |       - |   20544 B |
| **StringReplace** |       **replace3_1** |       **replace13_1** | **text50_000** |  **34,783.618 ns** |   **244.6309 ns** |   **228.8279 ns** |  **34,744.934 ns** | **32.2266** | **32.2266** | **32.2266** |  **102462 B** |
| RegexrReplace |       replace3_1 |       replace13_1 | text50_000 |  68,948.035 ns |   203.7323 ns |   190.5713 ns |  68,985.095 ns | 32.2266 | 32.2266 | 32.2266 |  102462 B |
| **StringReplace** |       **replace3_1** |       **replace21_1** |     **text10** |      **10.959 ns** |     **0.0322 ns** |     **0.0285 ns** |      **10.954 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace3_1 |       replace21_1 |     text10 |      56.222 ns |     0.1518 ns |     0.1420 ns |      56.199 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace3_1** |       **replace21_1** |     **text50** |      **15.160 ns** |     **0.0544 ns** |     **0.0509 ns** |      **15.157 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace3_1 |       replace21_1 |     text50 |      62.777 ns |     0.2249 ns |     0.1994 ns |      62.700 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace3_1** |       **replace21_1** |    **text100** |      **15.551 ns** |     **0.0306 ns** |     **0.0256 ns** |      **15.560 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace3_1 |       replace21_1 |    text100 |      80.397 ns |     0.2062 ns |     0.1828 ns |      80.364 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace3_1** |       **replace21_1** |    **text500** |     **167.861 ns** |     **0.6685 ns** |     **0.6253 ns** |     **168.053 ns** |  **0.2396** |       **-** |       **-** |    **1128 B** |
| RegexrReplace |       replace3_1 |       replace21_1 |    text500 |     553.560 ns |     1.7270 ns |     1.6154 ns |     553.156 ns |  0.2394 |       - |       - |    1128 B |
| **StringReplace** |       **replace3_1** |       **replace21_1** |  **text1_000** |     **270.627 ns** |     **1.9191 ns** |     **1.7952 ns** |     **270.950 ns** |  **0.4587** |       **-** |       **-** |    **2160 B** |
| RegexrReplace |       replace3_1 |       replace21_1 |  text1_000 |     880.507 ns |     3.2611 ns |     3.0504 ns |     881.167 ns |  0.4587 |       - |       - |    2160 B |
| **StringReplace** |       **replace3_1** |       **replace21_1** |  **text5_000** |   **1,160.449 ns** |     **3.7673 ns** |     **3.1459 ns** |   **1,162.208 ns** |  **2.2411** |       **-** |       **-** |   **10568 B** |
| RegexrReplace |       replace3_1 |       replace21_1 |  text5_000 |   3,601.368 ns |    12.7298 ns |    11.2846 ns |   3,599.096 ns |  2.2392 |       - |       - |   10568 B |
| **StringReplace** |       **replace3_1** |       **replace21_1** | **text10_000** |   **2,378.764 ns** |     **7.6397 ns** |     **7.1462 ns** |   **2,379.765 ns** |  **4.4441** |       **-** |       **-** |   **21008 B** |
| RegexrReplace |       replace3_1 |       replace21_1 | text10_000 |   7,197.530 ns |    33.9631 ns |    31.7691 ns |   7,209.802 ns |  4.4403 |       - |       - |   21008 B |
| **StringReplace** |       **replace3_1** |       **replace21_1** | **text50_000** |  **36,406.936 ns** |   **250.7284 ns** |   **234.5315 ns** |  **36,304.401 ns** | **32.2266** | **32.2266** | **32.2266** |  **104606 B** |
| RegexrReplace |       replace3_1 |       replace21_1 | text50_000 |  69,952.466 ns |   203.8657 ns |   190.6961 ns |  69,988.074 ns | 32.2266 | 32.2266 | 32.2266 |  104606 B |
| **StringReplace** |       **replace5_1** |        **replace1_1** |     **text10** |      **11.004 ns** |     **0.0329 ns** |     **0.0291 ns** |      **11.006 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace5_1 |        replace1_1 |     text10 |      49.193 ns |     0.0997 ns |     0.0933 ns |      49.167 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace5_1** |        **replace1_1** |     **text50** |      **14.821 ns** |     **0.0272 ns** |     **0.0227 ns** |      **14.825 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace5_1 |        replace1_1 |     text50 |      73.092 ns |     0.0573 ns |     0.0447 ns |      73.095 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace5_1** |        **replace1_1** |    **text100** |      **16.892 ns** |     **0.0253 ns** |     **0.0211 ns** |      **16.896 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace5_1 |        replace1_1 |    text100 |     101.284 ns |     0.1475 ns |     0.1380 ns |     101.245 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace5_1** |        **replace1_1** |    **text500** |     **145.350 ns** |     **1.5667 ns** |     **1.4655 ns** |     **145.045 ns** |  **0.2141** |       **-** |       **-** |    **1008 B** |
| RegexrReplace |       replace5_1 |        replace1_1 |    text500 |     590.576 ns |     1.7484 ns |     1.6354 ns |     590.661 ns |  0.2136 |       - |       - |    1008 B |
| **StringReplace** |       **replace5_1** |        **replace1_1** |  **text1_000** |     **228.709 ns** |     **1.3404 ns** |     **1.2538 ns** |     **228.627 ns** |  **0.4265** |       **-** |       **-** |    **2008 B** |
| RegexrReplace |       replace5_1 |        replace1_1 |  text1_000 |     975.194 ns |     3.1947 ns |     2.9883 ns |     974.883 ns |  0.4253 |       - |       - |    2008 B |
| **StringReplace** |       **replace5_1** |        **replace1_1** |  **text5_000** |   **1,024.388 ns** |     **0.8081 ns** |     **0.6748 ns** |   **1,024.307 ns** |  **2.1095** |       **-** |       **-** |    **9944 B** |
| RegexrReplace |       replace5_1 |        replace1_1 |  text5_000 |   4,315.856 ns |    20.5912 ns |    19.2610 ns |   4,315.579 ns |  2.1057 |       - |       - |    9944 B |
| **StringReplace** |       **replace5_1** |        **replace1_1** | **text10_000** |   **2,074.077 ns** |     **6.6688 ns** |     **5.5687 ns** |   **2,076.144 ns** |  **4.2000** |       **-** |       **-** |   **19872 B** |
| RegexrReplace |       replace5_1 |        replace1_1 | text10_000 |   8,490.824 ns |    39.4561 ns |    30.8047 ns |   8,487.222 ns |  4.1962 |       - |       - |   19872 B |
| **StringReplace** |       **replace5_1** |        **replace1_1** | **text50_000** |  **33,003.457 ns** |   **167.5954 ns** |   **139.9497 ns** |  **33,047.675 ns** | **31.1890** | **31.1890** | **31.1890** |   **99267 B** |
| RegexrReplace |       replace5_1 |        replace1_1 | text50_000 |  68,600.408 ns |   148.6075 ns |   139.0075 ns |  68,609.253 ns | 31.1279 | 31.1279 | 31.1279 |   99277 B |
| **StringReplace** |       **replace5_1** |        **replace2_1** |     **text10** |      **10.910 ns** |     **0.0171 ns** |     **0.0143 ns** |      **10.908 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace5_1 |        replace2_1 |     text10 |      59.558 ns |     0.1536 ns |     0.1437 ns |      59.524 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace5_1** |        **replace2_1** |     **text50** |      **14.825 ns** |     **0.0294 ns** |     **0.0245 ns** |      **14.828 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace5_1 |        replace2_1 |     text50 |      73.410 ns |     0.2652 ns |     0.2351 ns |      73.345 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace5_1** |        **replace2_1** |    **text100** |      **16.963 ns** |     **0.0684 ns** |     **0.0639 ns** |      **16.969 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace5_1 |        replace2_1 |    text100 |     104.601 ns |     0.6620 ns |     0.6192 ns |     104.350 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace5_1** |        **replace2_1** |    **text500** |     **144.786 ns** |     **0.9851 ns** |     **0.9215 ns** |     **145.190 ns** |  **0.2158** |       **-** |       **-** |    **1016 B** |
| RegexrReplace |       replace5_1 |        replace2_1 |    text500 |     577.985 ns |     2.2628 ns |     2.1166 ns |     577.686 ns |  0.2155 |       - |       - |    1016 B |
| **StringReplace** |       **replace5_1** |        **replace2_1** |  **text1_000** |     **226.072 ns** |     **0.3994 ns** |     **0.3736 ns** |     **226.046 ns** |  **0.4284** |       **-** |       **-** |    **2016 B** |
| RegexrReplace |       replace5_1 |        replace2_1 |  text1_000 |     967.649 ns |     2.7731 ns |     2.5939 ns |     967.402 ns |  0.4272 |       - |       - |    2016 B |
| **StringReplace** |       **replace5_1** |        **replace2_1** |  **text5_000** |   **1,004.041 ns** |     **3.3155 ns** |     **3.1013 ns** |   **1,005.255 ns** |  **2.1133** |       **-** |       **-** |    **9968 B** |
| RegexrReplace |       replace5_1 |        replace2_1 |  text5_000 |   4,266.404 ns |    10.8357 ns |    10.1357 ns |   4,266.604 ns |  2.1133 |       - |       - |    9968 B |
| **StringReplace** |       **replace5_1** |        **replace2_1** | **text10_000** |   **2,139.290 ns** |     **6.0925 ns** |     **4.7566 ns** |   **2,140.443 ns** |  **4.2191** |       **-** |       **-** |   **19912 B** |
| RegexrReplace |       replace5_1 |        replace2_1 | text10_000 |   8,465.556 ns |    42.0840 ns |    39.3654 ns |   8,451.816 ns |  4.2114 |       - |       - |   19912 B |
| **StringReplace** |       **replace5_1** |        **replace2_1** | **text50_000** |  **33,085.739 ns** |   **267.1601 ns** |   **249.9017 ns** |  **32,980.615 ns** | **31.1890** | **31.1890** | **31.1890** |   **99459 B** |
| RegexrReplace |       replace5_1 |        replace2_1 | text50_000 |  68,552.629 ns |   247.2415 ns |   231.2698 ns |  68,590.894 ns | 31.1279 | 31.1279 | 31.1279 |   99469 B |
| **StringReplace** |       **replace5_1** |        **replace3_1** |     **text10** |      **10.946 ns** |     **0.0416 ns** |     **0.0390 ns** |      **10.940 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace5_1 |        replace3_1 |     text10 |      51.767 ns |     0.0720 ns |     0.0638 ns |      51.784 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace5_1** |        **replace3_1** |     **text50** |      **14.733 ns** |     **0.0324 ns** |     **0.0253 ns** |      **14.747 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace5_1 |        replace3_1 |     text50 |      73.583 ns |     0.1960 ns |     0.1834 ns |      73.575 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace5_1** |        **replace3_1** |    **text100** |      **16.922 ns** |     **0.0561 ns** |     **0.0525 ns** |      **16.907 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace5_1 |        replace3_1 |    text100 |     104.048 ns |     0.2515 ns |     0.2100 ns |     104.145 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace5_1** |        **replace3_1** |    **text500** |     **144.202 ns** |     **1.0234 ns** |     **0.9573 ns** |     **144.812 ns** |  **0.2158** |       **-** |       **-** |    **1016 B** |
| RegexrReplace |       replace5_1 |        replace3_1 |    text500 |     581.415 ns |     4.1314 ns |     3.8645 ns |     580.273 ns |  0.2155 |       - |       - |    1016 B |
| **StringReplace** |       **replace5_1** |        **replace3_1** |  **text1_000** |     **225.965 ns** |     **2.1491 ns** |     **2.0103 ns** |     **224.817 ns** |  **0.4284** |       **-** |       **-** |    **2016 B** |
| RegexrReplace |       replace5_1 |        replace3_1 |  text1_000 |     992.537 ns |     3.2517 ns |     2.8825 ns |     991.882 ns |  0.4272 |       - |       - |    2016 B |
| **StringReplace** |       **replace5_1** |        **replace3_1** |  **text5_000** |   **1,018.052 ns** |     **3.8769 ns** |     **3.0269 ns** |   **1,019.443 ns** |  **2.1172** |       **-** |       **-** |    **9984 B** |
| RegexrReplace |       replace5_1 |        replace3_1 |  text5_000 |   4,294.598 ns |    16.1034 ns |    14.2752 ns |   4,291.908 ns |  2.1133 |       - |       - |    9984 B |
| **StringReplace** |       **replace5_1** |        **replace3_1** | **text10_000** |   **2,069.556 ns** |     **8.4926 ns** |     **7.9440 ns** |   **2,073.336 ns** |  **4.2191** |       **-** |       **-** |   **19952 B** |
| RegexrReplace |       replace5_1 |        replace3_1 | text10_000 |   8,449.999 ns |    31.0836 ns |    29.0756 ns |   8,453.534 ns |  4.2114 |       - |       - |   19952 B |
| **StringReplace** |       **replace5_1** |        **replace3_1** | **text50_000** |  **33,100.597 ns** |   **249.8824 ns** |   **233.7402 ns** |  **33,104.303 ns** | **31.1890** | **31.1890** | **31.1890** |   **99651 B** |
| RegexrReplace |       replace5_1 |        replace3_1 | text50_000 |  68,722.122 ns |   160.1149 ns |   149.7716 ns |  68,757.495 ns | 31.1279 | 31.1279 | 31.1279 |   99661 B |
| **StringReplace** |       **replace5_1** |        **replace5_1** |     **text10** |      **10.919 ns** |     **0.0533 ns** |     **0.0445 ns** |      **10.906 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace5_1 |        replace5_1 |     text10 |      58.276 ns |     0.2290 ns |     0.2142 ns |      58.315 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace5_1** |        **replace5_1** |     **text50** |      **14.833 ns** |     **0.0978 ns** |     **0.0867 ns** |      **14.823 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace5_1 |        replace5_1 |     text50 |      73.266 ns |     0.2274 ns |     0.2127 ns |      73.160 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace5_1** |        **replace5_1** |    **text100** |      **16.927 ns** |     **0.0431 ns** |     **0.0382 ns** |      **16.904 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace5_1 |        replace5_1 |    text100 |     106.611 ns |     0.3559 ns |     0.3155 ns |     106.559 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace5_1** |        **replace5_1** |    **text500** |     **144.395 ns** |     **0.8995 ns** |     **0.8414 ns** |     **144.639 ns** |  **0.2174** |       **-** |       **-** |    **1024 B** |
| RegexrReplace |       replace5_1 |        replace5_1 |    text500 |     588.339 ns |     1.9369 ns |     1.8118 ns |     588.556 ns |  0.2174 |       - |       - |    1024 B |
| **StringReplace** |       **replace5_1** |        **replace5_1** |  **text1_000** |     **227.952 ns** |     **2.8870 ns** |     **2.7005 ns** |     **228.191 ns** |  **0.4301** |       **-** |       **-** |    **2024 B** |
| RegexrReplace |       replace5_1 |        replace5_1 |  text1_000 |     957.622 ns |     3.3268 ns |     2.9491 ns |     957.350 ns |  0.4292 |       - |       - |    2024 B |
| **StringReplace** |       **replace5_1** |        **replace5_1** |  **text5_000** |   **1,034.255 ns** |     **1.8019 ns** |     **1.6855 ns** |   **1,035.170 ns** |  **2.1267** |       **-** |       **-** |   **10024 B** |
| RegexrReplace |       replace5_1 |        replace5_1 |  text5_000 |   4,297.528 ns |    15.3959 ns |    14.4013 ns |   4,297.273 ns |  2.1210 |       - |       - |   10024 B |
| **StringReplace** |       **replace5_1** |        **replace5_1** | **text10_000** |   **2,080.810 ns** |    **22.1232 ns** |    **20.6940 ns** |   **2,081.289 ns** |  **4.2343** |       **-** |       **-** |   **20024 B** |
| RegexrReplace |       replace5_1 |        replace5_1 | text10_000 |   8,449.536 ns |    62.1060 ns |    58.0940 ns |   8,437.859 ns |  4.2267 |       - |       - |   20024 B |
| **StringReplace** |       **replace5_1** |        **replace5_1** | **text50_000** |  **33,488.823 ns** |   **235.9101 ns** |   **220.6704 ns** |  **33,521.619 ns** | **31.1890** | **31.1890** | **31.1890** |  **100035 B** |
| RegexrReplace |       replace5_1 |        replace5_1 | text50_000 |  68,507.115 ns |   279.2479 ns |   261.2086 ns |  68,383.191 ns | 31.1279 | 31.1279 | 31.1279 |  100045 B |
| **StringReplace** |       **replace5_1** |        **replace8_1** |     **text10** |      **11.058 ns** |     **0.0581 ns** |     **0.0515 ns** |      **11.043 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace5_1 |        replace8_1 |     text10 |      57.948 ns |     0.1584 ns |     0.1405 ns |      57.920 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace5_1** |        **replace8_1** |     **text50** |      **14.767 ns** |     **0.0452 ns** |     **0.0423 ns** |      **14.746 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace5_1 |        replace8_1 |     text50 |      73.371 ns |     0.2438 ns |     0.2281 ns |      73.276 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace5_1** |        **replace8_1** |    **text100** |      **16.830 ns** |     **0.0571 ns** |     **0.0534 ns** |      **16.812 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace5_1 |        replace8_1 |    text100 |     108.181 ns |     0.2125 ns |     0.1988 ns |     108.152 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace5_1** |        **replace8_1** |    **text500** |     **146.305 ns** |     **0.5366 ns** |     **0.5020 ns** |     **146.398 ns** |  **0.2193** |       **-** |       **-** |    **1032 B** |
| RegexrReplace |       replace5_1 |        replace8_1 |    text500 |     583.076 ns |     1.7798 ns |     1.6648 ns |     582.601 ns |  0.2193 |       - |       - |    1032 B |
| **StringReplace** |       **replace5_1** |        **replace8_1** |  **text1_000** |     **228.522 ns** |     **0.8253 ns** |     **0.7720 ns** |     **228.940 ns** |  **0.4318** |       **-** |       **-** |    **2032 B** |
| RegexrReplace |       replace5_1 |        replace8_1 |  text1_000 |     998.555 ns |     3.7223 ns |     3.4818 ns |     998.527 ns |  0.4311 |       - |       - |    2032 B |
| **StringReplace** |       **replace5_1** |        **replace8_1** |  **text5_000** |   **1,025.293 ns** |     **1.8763 ns** |     **1.6633 ns** |   **1,025.260 ns** |  **2.1362** |       **-** |       **-** |   **10064 B** |
| RegexrReplace |       replace5_1 |        replace8_1 |  text5_000 |   4,275.342 ns |     7.4252 ns |     6.9455 ns |   4,277.204 ns |  2.1362 |       - |       - |   10064 B |
| **StringReplace** |       **replace5_1** |        **replace8_1** | **text10_000** |   **2,091.785 ns** |    **18.7227 ns** |    **17.5132 ns** |   **2,098.552 ns** |  **4.2534** |       **-** |       **-** |   **20104 B** |
| RegexrReplace |       replace5_1 |        replace8_1 | text10_000 |   8,478.837 ns |    41.2783 ns |    38.6118 ns |   8,492.319 ns |  4.2419 |       - |       - |   20104 B |
| **StringReplace** |       **replace5_1** |        **replace8_1** | **text50_000** |  **33,285.199 ns** |   **262.0780 ns** |   **245.1479 ns** |  **33,300.140 ns** | **31.1890** | **31.1890** | **31.1890** |  **100419 B** |
| RegexrReplace |       replace5_1 |        replace8_1 | text50_000 |  68,633.698 ns |   120.0843 ns |   100.2759 ns |  68,673.950 ns | 31.1279 | 31.1279 | 31.1279 |  100429 B |
| **StringReplace** |       **replace5_1** |       **replace13_1** |     **text10** |      **10.921 ns** |     **0.0263 ns** |     **0.0219 ns** |      **10.914 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace5_1 |       replace13_1 |     text10 |      58.634 ns |     0.1331 ns |     0.1245 ns |      58.611 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace5_1** |       **replace13_1** |     **text50** |      **14.837 ns** |     **0.0501 ns** |     **0.0444 ns** |      **14.832 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace5_1 |       replace13_1 |     text50 |      73.766 ns |     0.2981 ns |     0.2642 ns |      73.639 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace5_1** |       **replace13_1** |    **text100** |      **17.051 ns** |     **0.0538 ns** |     **0.0503 ns** |      **17.030 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace5_1 |       replace13_1 |    text100 |     107.310 ns |     0.1585 ns |     0.1405 ns |     107.323 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace5_1** |       **replace13_1** |    **text500** |     **148.349 ns** |     **1.0055 ns** |     **0.9405 ns** |     **148.429 ns** |  **0.2244** |       **-** |       **-** |    **1056 B** |
| RegexrReplace |       replace5_1 |       replace13_1 |    text500 |     580.874 ns |     1.8104 ns |     1.6935 ns |     581.128 ns |  0.2241 |       - |       - |    1056 B |
| **StringReplace** |       **replace5_1** |       **replace13_1** |  **text1_000** |     **228.077 ns** |     **2.2989 ns** |     **2.1504 ns** |     **227.415 ns** |  **0.4368** |       **-** |       **-** |    **2056 B** |
| RegexrReplace |       replace5_1 |       replace13_1 |  text1_000 |     965.287 ns |     4.7708 ns |     4.4626 ns |     966.749 ns |  0.4368 |       - |       - |    2056 B |
| **StringReplace** |       **replace5_1** |       **replace13_1** |  **text5_000** |   **1,017.377 ns** |     **6.7694 ns** |     **6.3321 ns** |   **1,021.801 ns** |  **2.1591** |       **-** |       **-** |   **10168 B** |
| RegexrReplace |       replace5_1 |       replace13_1 |  text5_000 |   4,294.367 ns |    12.0633 ns |     9.4182 ns |   4,294.402 ns |  2.1591 |       - |       - |   10168 B |
| **StringReplace** |       **replace5_1** |       **replace13_1** | **text10_000** |   **2,109.951 ns** |     **2.0540 ns** |     **1.9213 ns** |   **2,109.296 ns** |  **4.2915** |       **-** |       **-** |   **20288 B** |
| RegexrReplace |       replace5_1 |       replace13_1 | text10_000 |   8,454.045 ns |    25.8327 ns |    24.1639 ns |   8,446.814 ns |  4.2877 |       - |       - |   20288 B |
| **StringReplace** |       **replace5_1** |       **replace13_1** | **text50_000** |  **33,640.199 ns** |   **247.7702 ns** |   **231.7644 ns** |  **33,568.939 ns** | **31.1890** | **31.1890** | **31.1890** |  **101379 B** |
| RegexrReplace |       replace5_1 |       replace13_1 | text50_000 |  68,927.779 ns |   175.0335 ns |   163.7265 ns |  68,957.874 ns | 31.1279 | 31.1279 | 31.1279 |  101389 B |
| **StringReplace** |       **replace5_1** |       **replace21_1** |     **text10** |      **11.020 ns** |     **0.0299 ns** |     **0.0280 ns** |      **11.024 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace5_1 |       replace21_1 |     text10 |      48.549 ns |     0.1152 ns |     0.1077 ns |      48.571 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace5_1** |       **replace21_1** |     **text50** |      **14.730 ns** |     **0.0259 ns** |     **0.0216 ns** |      **14.737 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace5_1 |       replace21_1 |     text50 |      73.484 ns |     0.0914 ns |     0.0714 ns |      73.494 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace5_1** |       **replace21_1** |    **text100** |      **17.040 ns** |     **0.0438 ns** |     **0.0409 ns** |      **17.030 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace5_1 |       replace21_1 |    text100 |     104.396 ns |     0.1770 ns |     0.1656 ns |     104.365 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace5_1** |       **replace21_1** |    **text500** |     **148.379 ns** |     **0.5513 ns** |     **0.5157 ns** |     **148.441 ns** |  **0.2310** |       **-** |       **-** |    **1088 B** |
| RegexrReplace |       replace5_1 |       replace21_1 |    text500 |     570.715 ns |     1.7403 ns |     1.6279 ns |     570.828 ns |  0.2308 |       - |       - |    1088 B |
| **StringReplace** |       **replace5_1** |       **replace21_1** |  **text1_000** |     **241.256 ns** |     **4.8045 ns** |     **9.7054 ns** |     **238.613 ns** |  **0.4435** |       **-** |       **-** |    **2088 B** |
| RegexrReplace |       replace5_1 |       replace21_1 |  text1_000 |   1,023.262 ns |    12.4758 ns |    11.6699 ns |   1,022.073 ns |  0.4425 |       - |       - |    2088 B |
| **StringReplace** |       **replace5_1** |       **replace21_1** |  **text5_000** |   **1,202.434 ns** |    **45.4995 ns** |   **134.1563 ns** |   **1,174.667 ns** |  **2.1915** |       **-** |       **-** |   **10328 B** |
| RegexrReplace |       replace5_1 |       replace21_1 |  text5_000 |   4,573.723 ns |    59.0806 ns |    55.2640 ns |   4,578.624 ns |  2.1896 |       - |       - |   10328 B |
| **StringReplace** |       **replace5_1** |       **replace21_1** | **text10_000** |   **2,246.996 ns** |    **44.6975 ns** |    **41.8101 ns** |   **2,250.482 ns** |  **4.3640** |       **-** |       **-** |   **20592 B** |
| RegexrReplace |       replace5_1 |       replace21_1 | text10_000 |   8,917.684 ns |    88.8747 ns |    83.1334 ns |   8,937.421 ns |  4.3640 |       - |       - |   20592 B |
| **StringReplace** |       **replace5_1** |       **replace21_1** | **text50_000** |  **35,896.628 ns** |   **663.1923 ns** |   **651.3435 ns** |  **35,759.531 ns** | **32.2266** | **32.2266** | **32.2266** |  **102915 B** |
| RegexrReplace |       replace5_1 |       replace21_1 | text50_000 |  73,011.559 ns | 1,434.9380 ns | 1,342.2419 ns |  72,668.335 ns | 32.2266 | 32.2266 | 32.2266 |  102926 B |
| **StringReplace** |       **replace8_1** |        **replace1_1** |     **text10** |      **10.947 ns** |     **0.1202 ns** |     **0.1124 ns** |      **10.939 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace1_1 |     text10 |      56.166 ns |     0.1447 ns |     0.1353 ns |      56.193 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace1_1** |     **text50** |      **16.069 ns** |     **0.0538 ns** |     **0.0477 ns** |      **16.062 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace1_1 |     text50 |      73.142 ns |     1.4685 ns |     1.6912 ns |      72.241 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace1_1** |    **text100** |      **17.486 ns** |     **0.1087 ns** |     **0.1017 ns** |      **17.515 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace1_1 |    text100 |      99.495 ns |     1.1230 ns |     1.0505 ns |      99.419 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace1_1** |    **text500** |      **31.376 ns** |     **0.3218 ns** |     **0.3010 ns** |      **31.427 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace1_1 |    text500 |     286.839 ns |     0.9104 ns |     0.8516 ns |     286.414 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace1_1** |  **text1_000** |      **67.733 ns** |     **1.3500 ns** |     **1.3259 ns** |      **67.859 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace1_1 |  text1_000 |     525.822 ns |     7.3034 ns |     6.8316 ns |     527.620 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace1_1** |  **text5_000** |     **259.772 ns** |     **2.5432 ns** |     **2.3789 ns** |     **259.226 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace1_1 |  text5_000 |   2,309.829 ns |    35.4445 ns |    33.1548 ns |   2,305.147 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace1_1** | **text10_000** |     **522.429 ns** |     **6.6256 ns** |     **6.1976 ns** |     **521.184 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace1_1 | text10_000 |   4,631.857 ns |    69.8674 ns |    65.3540 ns |   4,654.462 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace1_1** | **text50_000** |   **3,068.618 ns** |    **59.9190 ns** |    **75.7783 ns** |   **3,053.307 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace1_1 | text50_000 |  23,459.786 ns |   453.2436 ns |   445.1458 ns |  23,470.735 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace2_1** |     **text10** |      **10.975 ns** |     **0.0786 ns** |     **0.0697 ns** |      **10.974 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace2_1 |     text10 |      54.185 ns |     0.4882 ns |     0.4567 ns |      54.256 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace2_1** |     **text50** |      **15.469 ns** |     **0.1702 ns** |     **0.1422 ns** |      **15.495 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace2_1 |     text50 |      77.087 ns |     1.0627 ns |     0.9940 ns |      76.754 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace2_1** |    **text100** |      **17.459 ns** |     **0.1786 ns** |     **0.1671 ns** |      **17.534 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace2_1 |    text100 |     102.057 ns |     0.5359 ns |     0.5013 ns |     101.949 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace2_1** |    **text500** |      **31.086 ns** |     **0.1947 ns** |     **0.1822 ns** |      **31.121 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace2_1 |    text500 |     281.230 ns |     2.6128 ns |     2.4440 ns |     280.953 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace2_1** |  **text1_000** |      **65.742 ns** |     **0.4333 ns** |     **0.4053 ns** |      **65.747 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace2_1 |  text1_000 |     519.761 ns |     3.9608 ns |     3.7050 ns |     520.147 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace2_1** |  **text5_000** |     **256.795 ns** |     **3.5011 ns** |     **3.2750 ns** |     **256.854 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace2_1 |  text5_000 |   2,266.899 ns |    26.9459 ns |    25.2052 ns |   2,261.407 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace2_1** | **text10_000** |     **513.750 ns** |     **2.2240 ns** |     **2.0803 ns** |     **513.650 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace2_1 | text10_000 |   4,500.848 ns |    21.9547 ns |    20.5364 ns |   4,500.817 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace2_1** | **text50_000** |   **2,944.883 ns** |    **13.7639 ns** |    **12.8747 ns** |   **2,943.326 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace2_1 | text50_000 |  22,393.729 ns |    89.9573 ns |    84.1461 ns |  22,387.524 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace3_1** |     **text10** |      **10.716 ns** |     **0.0449 ns** |     **0.0420 ns** |      **10.723 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace3_1 |     text10 |      54.892 ns |     0.4599 ns |     0.4077 ns |      55.050 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace3_1** |     **text50** |      **15.624 ns** |     **0.0577 ns** |     **0.0539 ns** |      **15.627 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace3_1 |     text50 |      78.855 ns |     1.5889 ns |     1.4862 ns |      79.821 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace3_1** |    **text100** |      **16.943 ns** |     **0.0666 ns** |     **0.0623 ns** |      **16.947 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace3_1 |    text100 |      97.143 ns |     0.8207 ns |     0.7677 ns |      96.975 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace3_1** |    **text500** |      **30.300 ns** |     **0.1234 ns** |     **0.1094 ns** |      **30.292 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace3_1 |    text500 |     290.363 ns |     1.5454 ns |     1.3699 ns |     290.420 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace3_1** |  **text1_000** |      **66.098 ns** |     **0.2417 ns** |     **0.2142 ns** |      **66.074 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace3_1 |  text1_000 |     511.190 ns |     1.7838 ns |     1.6685 ns |     511.247 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace3_1** |  **text5_000** |     **256.423 ns** |     **1.8103 ns** |     **1.5117 ns** |     **256.240 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace3_1 |  text5_000 |   2,223.894 ns |     6.8783 ns |     6.4340 ns |   2,221.850 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace3_1** | **text10_000** |     **506.968 ns** |     **2.4923 ns** |     **2.3313 ns** |     **507.224 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace3_1 | text10_000 |   4,499.464 ns |    17.8316 ns |    15.8073 ns |   4,499.834 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace3_1** | **text50_000** |   **2,938.010 ns** |    **17.8272 ns** |    **16.6756 ns** |   **2,934.333 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace3_1 | text50_000 |  22,399.948 ns |   102.6482 ns |    96.0172 ns |  22,397.141 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace5_1** |     **text10** |      **10.713 ns** |     **0.0309 ns** |     **0.0274 ns** |      **10.701 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace5_1 |     text10 |      51.033 ns |     0.1722 ns |     0.1527 ns |      51.022 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace5_1** |     **text50** |      **14.928 ns** |     **0.0630 ns** |     **0.0589 ns** |      **14.932 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace5_1 |     text50 |      72.999 ns |     0.3225 ns |     0.2518 ns |      72.959 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace5_1** |    **text100** |      **16.939 ns** |     **0.0783 ns** |     **0.0694 ns** |      **16.938 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace5_1 |    text100 |      96.771 ns |     0.3536 ns |     0.3307 ns |      96.822 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace5_1** |    **text500** |      **30.175 ns** |     **0.1396 ns** |     **0.1237 ns** |      **30.215 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace5_1 |    text500 |     287.695 ns |     1.2240 ns |     1.0851 ns |     287.378 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace5_1** |  **text1_000** |      **66.357 ns** |     **0.3274 ns** |     **0.3063 ns** |      **66.278 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace5_1 |  text1_000 |     508.211 ns |     2.1117 ns |     1.9753 ns |     507.932 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace5_1** |  **text5_000** |     **255.483 ns** |     **1.1500 ns** |     **1.0757 ns** |     **255.960 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace5_1 |  text5_000 |   2,230.078 ns |    10.2036 ns |     9.0453 ns |   2,233.024 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace5_1** | **text10_000** |     **508.450 ns** |     **2.2572 ns** |     **1.7623 ns** |     **508.120 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace5_1 | text10_000 |   4,496.562 ns |    21.0321 ns |    19.6734 ns |   4,495.354 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace5_1** | **text50_000** |   **2,801.579 ns** |    **10.1209 ns** |     **8.9719 ns** |   **2,800.016 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace5_1 | text50_000 |  22,419.201 ns |   158.5404 ns |   148.2988 ns |  22,415.390 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace8_1** |     **text10** |      **10.735 ns** |     **0.0378 ns** |     **0.0353 ns** |      **10.737 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace8_1 |     text10 |      47.719 ns |     0.2006 ns |     0.1778 ns |      47.691 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace8_1** |     **text50** |      **15.556 ns** |     **0.0530 ns** |     **0.0496 ns** |      **15.555 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace8_1 |     text50 |      77.391 ns |     0.4970 ns |     0.4406 ns |      77.323 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace8_1** |    **text100** |      **16.977 ns** |     **0.0567 ns** |     **0.0474 ns** |      **16.993 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace8_1 |    text100 |     100.194 ns |     0.4265 ns |     0.3781 ns |     100.301 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace8_1** |    **text500** |      **30.346 ns** |     **0.1443 ns** |     **0.1350 ns** |      **30.347 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace8_1 |    text500 |     282.066 ns |     1.2352 ns |     1.1554 ns |     282.224 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace8_1** |  **text1_000** |      **66.175 ns** |     **0.2881 ns** |     **0.2695 ns** |      **66.168 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace8_1 |  text1_000 |     508.527 ns |     1.3707 ns |     1.2151 ns |     508.355 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace8_1** |  **text5_000** |     **255.546 ns** |     **0.9887 ns** |     **0.8764 ns** |     **255.448 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace8_1 |  text5_000 |   2,226.924 ns |     8.9978 ns |     8.4166 ns |   2,229.517 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace8_1** | **text10_000** |     **514.612 ns** |     **6.9084 ns** |     **6.4621 ns** |     **511.180 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace8_1 | text10_000 |   4,496.564 ns |    22.4637 ns |    21.0126 ns |   4,495.829 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |        **replace8_1** | **text50_000** |   **2,908.638 ns** |    **16.4877 ns** |    **15.4226 ns** |   **2,910.673 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |        replace8_1 | text50_000 |  22,336.511 ns |    94.4438 ns |    78.8649 ns |  22,344.022 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |       **replace13_1** |     **text10** |      **10.702 ns** |     **0.0418 ns** |     **0.0391 ns** |      **10.712 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |       replace13_1 |     text10 |      48.227 ns |     0.1631 ns |     0.1446 ns |      48.175 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |       **replace13_1** |     **text50** |      **14.924 ns** |     **0.1030 ns** |     **0.0963 ns** |      **14.911 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |       replace13_1 |     text50 |      81.346 ns |     0.5089 ns |     0.3973 ns |      81.391 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |       **replace13_1** |    **text100** |      **17.221 ns** |     **0.0680 ns** |     **0.0603 ns** |      **17.213 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |       replace13_1 |    text100 |      96.507 ns |     0.2749 ns |     0.2437 ns |      96.436 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |       **replace13_1** |    **text500** |      **30.836 ns** |     **0.1072 ns** |     **0.1003 ns** |      **30.844 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |       replace13_1 |    text500 |     278.412 ns |     1.3693 ns |     1.2808 ns |     278.380 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |       **replace13_1** |  **text1_000** |      **65.399 ns** |     **0.2968 ns** |     **0.2479 ns** |      **65.358 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |       replace13_1 |  text1_000 |     512.223 ns |     3.1428 ns |     2.9398 ns |     511.968 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |       **replace13_1** |  **text5_000** |     **254.552 ns** |     **4.4477 ns** |     **4.1604 ns** |     **253.474 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |       replace13_1 |  text5_000 |   2,208.786 ns |     9.7649 ns |     8.6563 ns |   2,209.471 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |       **replace13_1** | **text10_000** |     **501.233 ns** |     **1.9970 ns** |     **1.8680 ns** |     **501.065 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |       replace13_1 | text10_000 |   4,450.474 ns |    11.5605 ns |    10.2481 ns |   4,449.732 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |       **replace13_1** | **text50_000** |   **2,873.271 ns** |    **11.2548 ns** |    **10.5278 ns** |   **2,868.708 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |       replace13_1 | text50_000 |  22,142.065 ns |    87.0732 ns |    81.4483 ns |  22,128.012 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |       **replace21_1** |     **text10** |      **10.581 ns** |     **0.0256 ns** |     **0.0240 ns** |      **10.583 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |       replace21_1 |     text10 |      48.152 ns |     0.0878 ns |     0.0779 ns |      48.138 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |       **replace21_1** |     **text50** |      **14.784 ns** |     **0.0566 ns** |     **0.0530 ns** |      **14.791 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |       replace21_1 |     text50 |      74.879 ns |     0.3991 ns |     0.3538 ns |      74.869 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |       **replace21_1** |    **text100** |      **17.065 ns** |     **0.0643 ns** |     **0.0601 ns** |      **17.040 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |       replace21_1 |    text100 |      95.062 ns |     0.2615 ns |     0.2446 ns |      95.035 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |       **replace21_1** |    **text500** |      **30.483 ns** |     **0.0780 ns** |     **0.0609 ns** |      **30.453 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |       replace21_1 |    text500 |     274.364 ns |     0.7860 ns |     0.7352 ns |     274.134 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |       **replace21_1** |  **text1_000** |      **66.000 ns** |     **0.1683 ns** |     **0.1574 ns** |      **65.918 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |       replace21_1 |  text1_000 |     501.537 ns |     1.4530 ns |     1.3592 ns |     500.946 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |       **replace21_1** |  **text5_000** |     **247.511 ns** |     **0.6172 ns** |     **0.4819 ns** |     **247.729 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |       replace21_1 |  text5_000 |   2,203.596 ns |     8.0651 ns |     7.1495 ns |   2,202.263 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |       **replace21_1** | **text10_000** |     **507.653 ns** |     **6.1501 ns** |     **5.7528 ns** |     **505.849 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |       replace21_1 | text10_000 |   4,446.033 ns |    11.6564 ns |    10.3331 ns |   4,443.718 ns |       - |       - |       - |         - |
| **StringReplace** |       **replace8_1** |       **replace21_1** | **text50_000** |   **2,896.161 ns** |     **8.2914 ns** |     **7.7558 ns** |   **2,894.485 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |       replace8_1 |       replace21_1 | text50_000 |  22,124.710 ns |    64.4753 ns |    57.1556 ns |  22,123.767 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace1_1** |     **text10** |       **7.779 ns** |     **0.0166 ns** |     **0.0155 ns** |       **7.770 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace1_1 |     text10 |      55.868 ns |     0.3521 ns |     0.3293 ns |      55.990 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace1_1** |     **text50** |      **14.482 ns** |     **0.0541 ns** |     **0.0506 ns** |      **14.488 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace1_1 |     text50 |      62.997 ns |     0.1074 ns |     0.0952 ns |      62.998 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace1_1** |    **text100** |      **17.644 ns** |     **0.0423 ns** |     **0.0395 ns** |      **17.622 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace1_1 |    text100 |      92.071 ns |     0.2178 ns |     0.1818 ns |      91.995 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace1_1** |    **text500** |      **31.040 ns** |     **0.0391 ns** |     **0.0326 ns** |      **31.029 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace1_1 |    text500 |     284.192 ns |     1.0437 ns |     0.9763 ns |     284.042 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace1_1** |  **text1_000** |      **58.029 ns** |     **0.0904 ns** |     **0.0706 ns** |      **58.024 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace1_1 |  text1_000 |     502.341 ns |     1.2335 ns |     1.1538 ns |     501.936 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace1_1** |  **text5_000** |     **228.773 ns** |     **0.5187 ns** |     **0.4852 ns** |     **228.654 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace1_1 |  text5_000 |   2,325.417 ns |     6.4997 ns |     5.4275 ns |   2,324.559 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace1_1** | **text10_000** |     **459.151 ns** |     **1.3443 ns** |     **1.2575 ns** |     **458.456 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace1_1 | text10_000 |   4,739.094 ns |    22.2254 ns |    20.7896 ns |   4,729.292 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace1_1** | **text50_000** |   **2,457.414 ns** |    **10.1275 ns** |     **9.4733 ns** |   **2,455.279 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace1_1 | text50_000 |  24,468.996 ns |    56.0500 ns |    52.4292 ns |  24,476.758 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace2_1** |     **text10** |       **7.832 ns** |     **0.0263 ns** |     **0.0233 ns** |       **7.832 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace2_1 |     text10 |      56.096 ns |     0.1556 ns |     0.1379 ns |      56.067 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace2_1** |     **text50** |      **14.503 ns** |     **0.0351 ns** |     **0.0311 ns** |      **14.491 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace2_1 |     text50 |      69.404 ns |     0.3351 ns |     0.3135 ns |      69.272 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace2_1** |    **text100** |      **17.823 ns** |     **0.2568 ns** |     **0.2277 ns** |      **17.723 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace2_1 |    text100 |      94.488 ns |     1.2205 ns |     1.1417 ns |      94.901 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace2_1** |    **text500** |      **31.166 ns** |     **0.1054 ns** |     **0.0934 ns** |      **31.129 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace2_1 |    text500 |     283.711 ns |     0.5095 ns |     0.4255 ns |     283.736 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace2_1** |  **text1_000** |      **56.674 ns** |     **0.1303 ns** |     **0.1155 ns** |      **56.661 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace2_1 |  text1_000 |     501.535 ns |     1.4606 ns |     1.3663 ns |     501.566 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace2_1** |  **text5_000** |     **228.565 ns** |     **0.4269 ns** |     **0.3784 ns** |     **228.566 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace2_1 |  text5_000 |   2,343.181 ns |    19.9990 ns |    18.7071 ns |   2,337.029 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace2_1** | **text10_000** |     **464.243 ns** |     **6.3334 ns** |     **5.9243 ns** |     **461.766 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace2_1 | text10_000 |   4,757.648 ns |     9.4914 ns |     7.9257 ns |   4,757.724 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace2_1** | **text50_000** |   **2,480.761 ns** |     **9.7729 ns** |     **9.1416 ns** |   **2,478.959 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace2_1 | text50_000 |  24,558.779 ns |    55.9120 ns |    49.5645 ns |  24,573.810 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace3_1** |     **text10** |       **7.872 ns** |     **0.0413 ns** |     **0.0386 ns** |       **7.865 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace3_1 |     text10 |      58.036 ns |     0.0940 ns |     0.0879 ns |      58.032 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace3_1** |     **text50** |      **14.528 ns** |     **0.0436 ns** |     **0.0387 ns** |      **14.533 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace3_1 |     text50 |      63.568 ns |     0.1713 ns |     0.1603 ns |      63.544 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace3_1** |    **text100** |      **17.860 ns** |     **0.0587 ns** |     **0.0549 ns** |      **17.851 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace3_1 |    text100 |      92.622 ns |     0.2547 ns |     0.2258 ns |      92.650 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace3_1** |    **text500** |      **31.255 ns** |     **0.1252 ns** |     **0.1171 ns** |      **31.237 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace3_1 |    text500 |     285.542 ns |     1.0719 ns |     1.0027 ns |     285.748 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace3_1** |  **text1_000** |      **56.349 ns** |     **0.2618 ns** |     **0.2449 ns** |      **56.380 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace3_1 |  text1_000 |     502.879 ns |     1.5468 ns |     1.4469 ns |     502.574 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace3_1** |  **text5_000** |     **229.777 ns** |     **0.4816 ns** |     **0.4269 ns** |     **229.806 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace3_1 |  text5_000 |   2,333.500 ns |     5.8528 ns |     4.8873 ns |   2,333.041 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace3_1** | **text10_000** |     **464.257 ns** |     **1.5765 ns** |     **1.4747 ns** |     **464.323 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace3_1 | text10_000 |   4,747.703 ns |    13.6797 ns |    12.1267 ns |   4,742.964 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace3_1** | **text50_000** |   **2,475.230 ns** |    **14.5725 ns** |    **13.6311 ns** |   **2,482.733 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace3_1 | text50_000 |  24,565.885 ns |    97.1166 ns |    90.8429 ns |  24,569.965 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace5_1** |     **text10** |       **7.835 ns** |     **0.0370 ns** |     **0.0346 ns** |       **7.818 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace5_1 |     text10 |      49.919 ns |     0.1218 ns |     0.1139 ns |      49.906 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace5_1** |     **text50** |      **14.513 ns** |     **0.0239 ns** |     **0.0212 ns** |      **14.520 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace5_1 |     text50 |      63.466 ns |     0.1515 ns |     0.1417 ns |      63.436 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace5_1** |    **text100** |      **17.715 ns** |     **0.0394 ns** |     **0.0369 ns** |      **17.716 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace5_1 |    text100 |      92.387 ns |     0.2728 ns |     0.2552 ns |      92.433 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace5_1** |    **text500** |      **31.133 ns** |     **0.1078 ns** |     **0.1009 ns** |      **31.116 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace5_1 |    text500 |     282.531 ns |     0.8797 ns |     0.8228 ns |     282.498 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace5_1** |  **text1_000** |      **56.198 ns** |     **0.2991 ns** |     **0.2798 ns** |      **56.161 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace5_1 |  text1_000 |     499.554 ns |     1.3455 ns |     1.2586 ns |     499.778 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace5_1** |  **text5_000** |     **220.107 ns** |     **0.6949 ns** |     **0.6500 ns** |     **220.085 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace5_1 |  text5_000 |   2,328.811 ns |     6.8217 ns |     6.0473 ns |   2,327.976 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace5_1** | **text10_000** |     **464.319 ns** |     **2.0227 ns** |     **1.8920 ns** |     **464.639 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace5_1 | text10_000 |   4,751.152 ns |    16.7274 ns |    15.6468 ns |   4,749.333 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace5_1** | **text50_000** |   **2,471.575 ns** |     **5.6628 ns** |     **4.7287 ns** |   **2,473.400 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace5_1 | text50_000 |  24,548.081 ns |    59.7144 ns |    52.9352 ns |  24,565.535 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace8_1** |     **text10** |       **8.068 ns** |     **0.0732 ns** |     **0.0685 ns** |       **8.059 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace8_1 |     text10 |      56.511 ns |     0.3589 ns |     0.3357 ns |      56.475 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace8_1** |     **text50** |      **14.506 ns** |     **0.0309 ns** |     **0.0258 ns** |      **14.512 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace8_1 |     text50 |      63.777 ns |     0.1591 ns |     0.1328 ns |      63.725 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace8_1** |    **text100** |      **17.850 ns** |     **0.0634 ns** |     **0.0593 ns** |      **17.858 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace8_1 |    text100 |      93.111 ns |     0.2498 ns |     0.2337 ns |      93.074 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace8_1** |    **text500** |      **31.187 ns** |     **0.0608 ns** |     **0.0474 ns** |      **31.206 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace8_1 |    text500 |     286.580 ns |     0.7462 ns |     0.6980 ns |     286.406 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace8_1** |  **text1_000** |      **57.145 ns** |     **0.3007 ns** |     **0.2813 ns** |      **57.160 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace8_1 |  text1_000 |     508.152 ns |     1.3930 ns |     1.3030 ns |     508.287 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace8_1** |  **text5_000** |     **228.410 ns** |     **0.6151 ns** |     **0.5754 ns** |     **228.405 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace8_1 |  text5_000 |   2,330.286 ns |     8.2883 ns |     7.7529 ns |   2,329.956 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace8_1** | **text10_000** |     **471.618 ns** |     **1.8880 ns** |     **1.7660 ns** |     **471.523 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace8_1 | text10_000 |   4,761.680 ns |    13.6473 ns |    12.7657 ns |   4,760.045 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |        **replace8_1** | **text50_000** |   **2,468.247 ns** |    **10.6854 ns** |     **9.9951 ns** |   **2,467.922 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |        replace8_1 | text50_000 |  24,559.622 ns |    70.3299 ns |    65.7866 ns |  24,576.819 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |       **replace13_1** |     **text10** |       **7.821 ns** |     **0.0245 ns** |     **0.0217 ns** |       **7.824 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |       replace13_1 |     text10 |      48.211 ns |     0.1394 ns |     0.1304 ns |      48.186 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |       **replace13_1** |     **text50** |      **15.033 ns** |     **0.0440 ns** |     **0.0390 ns** |      **15.036 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |       replace13_1 |     text50 |      66.363 ns |     0.5040 ns |     0.4468 ns |      66.210 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |       **replace13_1** |    **text100** |      **16.938 ns** |     **0.0492 ns** |     **0.0436 ns** |      **16.938 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |       replace13_1 |    text100 |      92.114 ns |     0.1842 ns |     0.1538 ns |      92.149 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |       **replace13_1** |    **text500** |      **31.122 ns** |     **0.1371 ns** |     **0.1215 ns** |      **31.081 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |       replace13_1 |    text500 |     282.349 ns |     0.7713 ns |     0.7215 ns |     282.050 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |       **replace13_1** |  **text1_000** |      **57.596 ns** |     **0.2615 ns** |     **0.2184 ns** |      **57.532 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |       replace13_1 |  text1_000 |     499.242 ns |     1.3212 ns |     1.0315 ns |     499.603 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |       **replace13_1** |  **text5_000** |     **220.752 ns** |     **1.1776 ns** |     **1.0439 ns** |     **220.770 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |       replace13_1 |  text5_000 |   2,332.836 ns |     7.8126 ns |     7.3079 ns |   2,330.115 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |       **replace13_1** | **text10_000** |     **474.687 ns** |     **7.2283 ns** |     **6.7614 ns** |     **477.241 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |       replace13_1 | text10_000 |   4,756.221 ns |    19.2384 ns |    17.9957 ns |   4,755.947 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |       **replace13_1** | **text50_000** |   **2,474.671 ns** |    **10.8936 ns** |    **10.1899 ns** |   **2,475.286 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |       replace13_1 | text50_000 |  24,560.593 ns |    87.5548 ns |    81.8988 ns |  24,573.558 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |       **replace21_1** |     **text10** |       **7.865 ns** |     **0.0212 ns** |     **0.0188 ns** |       **7.863 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |       replace21_1 |     text10 |      56.306 ns |     0.2490 ns |     0.2330 ns |      56.297 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |       **replace21_1** |     **text50** |      **15.223 ns** |     **0.0499 ns** |     **0.0442 ns** |      **15.217 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |       replace21_1 |     text50 |      64.709 ns |     1.3141 ns |     1.3495 ns |      64.003 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |       **replace21_1** |    **text100** |      **17.828 ns** |     **0.0506 ns** |     **0.0473 ns** |      **17.819 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |       replace21_1 |    text100 |      94.669 ns |     0.2683 ns |     0.2510 ns |      94.626 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |       **replace21_1** |    **text500** |      **31.227 ns** |     **0.1262 ns** |     **0.1180 ns** |      **31.205 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |       replace21_1 |    text500 |     286.109 ns |     0.5523 ns |     0.4612 ns |     285.838 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |       **replace21_1** |  **text1_000** |      **56.082 ns** |     **0.2258 ns** |     **0.2112 ns** |      **56.109 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |       replace21_1 |  text1_000 |     501.787 ns |     2.2197 ns |     2.0763 ns |     502.484 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |       **replace21_1** |  **text5_000** |     **220.982 ns** |     **0.8558 ns** |     **0.7586 ns** |     **220.997 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |       replace21_1 |  text5_000 |   2,331.857 ns |     7.9639 ns |     7.4494 ns |   2,331.815 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |       **replace21_1** | **text10_000** |     **465.399 ns** |     **1.3867 ns** |     **1.2293 ns** |     **465.166 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |       replace21_1 | text10_000 |   4,755.999 ns |    11.3593 ns |    10.6255 ns |   4,755.312 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace13_1** |       **replace21_1** | **text50_000** |   **2,468.429 ns** |    **19.3686 ns** |    **18.1174 ns** |   **2,463.319 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace13_1 |       replace21_1 | text50_000 |  24,555.418 ns |    79.4376 ns |    70.4194 ns |  24,546.059 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace1_1** |     **text10** |       **7.825 ns** |     **0.0199 ns** |     **0.0177 ns** |       **7.815 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace1_1 |     text10 |      59.000 ns |     0.2025 ns |     0.1691 ns |      58.984 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace1_1** |     **text50** |      **14.617 ns** |     **0.0564 ns** |     **0.0528 ns** |      **14.623 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace1_1 |     text50 |      54.241 ns |     0.1762 ns |     0.1648 ns |      54.231 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace1_1** |    **text100** |      **16.446 ns** |     **0.0455 ns** |     **0.0425 ns** |      **16.448 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace1_1 |    text100 |      66.341 ns |     0.2693 ns |     0.2387 ns |      66.268 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace1_1** |    **text500** |      **30.667 ns** |     **0.0928 ns** |     **0.0868 ns** |      **30.686 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace1_1 |    text500 |     165.425 ns |     0.8496 ns |     0.7947 ns |     165.441 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace1_1** |  **text1_000** |      **53.860 ns** |     **0.1787 ns** |     **0.1671 ns** |      **53.904 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace1_1 |  text1_000 |     307.900 ns |     0.9226 ns |     0.8179 ns |     307.840 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace1_1** |  **text5_000** |     **217.436 ns** |     **0.7126 ns** |     **0.6665 ns** |     **217.576 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace1_1 |  text5_000 |   1,398.239 ns |     5.0464 ns |     4.7204 ns |   1,399.081 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace1_1** | **text10_000** |   **1,643.577 ns** |     **2.3550 ns** |     **1.8386 ns** |   **1,643.657 ns** |  **4.2362** |       **-** |       **-** |   **19984 B** |
| RegexrReplace |      replace21_1 |        replace1_1 | text10_000 |   4,431.783 ns |     7.5324 ns |     7.0458 ns |   4,434.087 ns |  4.2343 |       - |       - |   19984 B |
| **StringReplace** |      **replace21_1** |        **replace1_1** | **text50_000** |  **33,100.284 ns** |   **234.3861 ns** |   **219.2449 ns** |  **33,055.713 ns** | **31.1890** | **31.1890** | **31.1890** |   **99923 B** |
| RegexrReplace |      replace21_1 |        replace1_1 | text50_000 |  48,106.195 ns |   143.7161 ns |   120.0094 ns |  48,098.639 ns | 31.1890 | 31.1890 | 31.1890 |   99933 B |
| **StringReplace** |      **replace21_1** |        **replace2_1** |     **text10** |       **7.946 ns** |     **0.0232 ns** |     **0.0217 ns** |       **7.952 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace2_1 |     text10 |      49.840 ns |     0.0961 ns |     0.0802 ns |      49.841 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace2_1** |     **text50** |      **14.477 ns** |     **0.0512 ns** |     **0.0479 ns** |      **14.480 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace2_1 |     text50 |      54.526 ns |     0.1359 ns |     0.1271 ns |      54.498 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace2_1** |    **text100** |      **17.067 ns** |     **0.0517 ns** |     **0.0484 ns** |      **17.054 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace2_1 |    text100 |      67.283 ns |     0.2682 ns |     0.2378 ns |      67.377 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace2_1** |    **text500** |      **30.704 ns** |     **0.1143 ns** |     **0.1069 ns** |      **30.694 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace2_1 |    text500 |     165.589 ns |     0.5978 ns |     0.5591 ns |     165.587 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace2_1** |  **text1_000** |      **54.238 ns** |     **0.2091 ns** |     **0.1956 ns** |      **54.189 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace2_1 |  text1_000 |     308.000 ns |     1.4573 ns |     1.2918 ns |     307.928 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace2_1** |  **text5_000** |     **226.412 ns** |     **0.7883 ns** |     **0.7373 ns** |     **226.466 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace2_1 |  text5_000 |   1,396.233 ns |     5.8210 ns |     5.4450 ns |   1,396.377 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace2_1** | **text10_000** |   **1,657.246 ns** |    **10.2387 ns** |     **9.5773 ns** |   **1,651.845 ns** |  **4.2362** |       **-** |       **-** |   **19992 B** |
| RegexrReplace |      replace21_1 |        replace2_1 | text10_000 |   4,410.249 ns |    16.5526 ns |    15.4833 ns |   4,406.121 ns |  4.2343 |       - |       - |   19992 B |
| **StringReplace** |      **replace21_1** |        **replace2_1** | **text50_000** |  **33,014.437 ns** |   **268.4175 ns** |   **251.0779 ns** |  **33,011.737 ns** | **31.1890** | **31.1890** | **31.1890** |   **99931 B** |
| RegexrReplace |      replace21_1 |        replace2_1 | text50_000 |  48,447.760 ns |   128.4009 ns |   120.1063 ns |  48,481.427 ns | 31.1890 | 31.1890 | 31.1890 |   99941 B |
| **StringReplace** |      **replace21_1** |        **replace3_1** |     **text10** |       **7.803 ns** |     **0.0405 ns** |     **0.0378 ns** |       **7.782 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace3_1 |     text10 |      48.395 ns |     0.1603 ns |     0.1499 ns |      48.390 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace3_1** |     **text50** |      **14.623 ns** |     **0.0621 ns** |     **0.0581 ns** |      **14.632 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace3_1 |     text50 |      53.494 ns |     0.1838 ns |     0.1719 ns |      53.445 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace3_1** |    **text100** |      **16.935 ns** |     **0.0570 ns** |     **0.0533 ns** |      **16.922 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace3_1 |    text100 |      66.957 ns |     0.2583 ns |     0.2289 ns |      66.958 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace3_1** |    **text500** |      **30.670 ns** |     **0.0850 ns** |     **0.0754 ns** |      **30.694 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace3_1 |    text500 |     168.046 ns |     0.5926 ns |     0.5254 ns |     167.976 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace3_1** |  **text1_000** |      **55.387 ns** |     **0.2228 ns** |     **0.1860 ns** |      **55.382 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace3_1 |  text1_000 |     312.349 ns |     1.1148 ns |     1.0427 ns |     312.513 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace3_1** |  **text5_000** |     **215.971 ns** |     **0.6921 ns** |     **0.6135 ns** |     **215.952 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace3_1 |  text5_000 |   1,395.089 ns |     4.5738 ns |     4.2783 ns |   1,395.904 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace3_1** | **text10_000** |   **1,670.376 ns** |    **29.5603 ns** |    **47.7343 ns** |   **1,662.514 ns** |  **4.2362** |       **-** |       **-** |   **19992 B** |
| RegexrReplace |      replace21_1 |        replace3_1 | text10_000 |   4,541.350 ns |    18.2268 ns |    15.2202 ns |   4,538.384 ns |  4.2343 |       - |       - |   19992 B |
| **StringReplace** |      **replace21_1** |        **replace3_1** | **text50_000** |  **33,343.615 ns** |   **230.6285 ns** |   **215.7300 ns** |  **33,391.028 ns** | **31.1890** | **31.1890** | **31.1890** |   **99931 B** |
| RegexrReplace |      replace21_1 |        replace3_1 | text50_000 |  48,531.416 ns |   203.9802 ns |   180.8231 ns |  48,476.883 ns | 31.1890 | 31.1890 | 31.1890 |   99941 B |
| **StringReplace** |      **replace21_1** |        **replace5_1** |     **text10** |       **7.880 ns** |     **0.0343 ns** |     **0.0304 ns** |       **7.879 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace5_1 |     text10 |      50.800 ns |     0.1256 ns |     0.1175 ns |      50.786 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace5_1** |     **text50** |      **14.598 ns** |     **0.0501 ns** |     **0.0391 ns** |      **14.603 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace5_1 |     text50 |      50.982 ns |     0.2758 ns |     0.2580 ns |      51.080 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace5_1** |    **text100** |      **17.060 ns** |     **0.0457 ns** |     **0.0428 ns** |      **17.064 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace5_1 |    text100 |      65.484 ns |     0.2270 ns |     0.2123 ns |      65.443 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace5_1** |    **text500** |      **30.715 ns** |     **0.1103 ns** |     **0.1032 ns** |      **30.699 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace5_1 |    text500 |     164.604 ns |     0.4413 ns |     0.3912 ns |     164.739 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace5_1** |  **text1_000** |      **53.679 ns** |     **0.2008 ns** |     **0.1878 ns** |      **53.668 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace5_1 |  text1_000 |     307.981 ns |     0.7187 ns |     0.6723 ns |     307.915 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace5_1** |  **text5_000** |     **216.816 ns** |     **1.0450 ns** |     **0.9775 ns** |     **216.932 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace5_1 |  text5_000 |   1,395.099 ns |     4.1459 ns |     3.6752 ns |   1,394.644 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace5_1** | **text10_000** |   **1,666.309 ns** |    **15.1330 ns** |    **14.1554 ns** |   **1,662.649 ns** |  **4.2362** |       **-** |       **-** |   **19992 B** |
| RegexrReplace |      replace21_1 |        replace5_1 | text10_000 |   4,431.227 ns |     8.8658 ns |     8.2930 ns |   4,428.733 ns |  4.2343 |       - |       - |   19992 B |
| **StringReplace** |      **replace21_1** |        **replace5_1** | **text50_000** |  **33,421.770 ns** |   **225.0447 ns** |   **210.5069 ns** |  **33,407.269 ns** | **31.1890** | **31.1890** | **31.1890** |   **99947 B** |
| RegexrReplace |      replace21_1 |        replace5_1 | text50_000 |  48,920.692 ns |   222.6289 ns |   208.2473 ns |  48,912.878 ns | 31.1890 | 31.1890 | 31.1890 |   99957 B |
| **StringReplace** |      **replace21_1** |        **replace8_1** |     **text10** |       **7.899 ns** |     **0.0258 ns** |     **0.0229 ns** |       **7.898 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace8_1 |     text10 |      49.579 ns |     0.0891 ns |     0.0696 ns |      49.604 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace8_1** |     **text50** |      **14.607 ns** |     **0.0436 ns** |     **0.0408 ns** |      **14.613 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace8_1 |     text50 |      54.205 ns |     0.1154 ns |     0.1079 ns |      54.189 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace8_1** |    **text100** |      **17.068 ns** |     **0.0439 ns** |     **0.0411 ns** |      **17.049 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace8_1 |    text100 |      66.123 ns |     0.1601 ns |     0.1497 ns |      66.086 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace8_1** |    **text500** |      **30.703 ns** |     **0.1178 ns** |     **0.1101 ns** |      **30.681 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace8_1 |    text500 |     165.056 ns |     0.5809 ns |     0.5434 ns |     164.943 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace8_1** |  **text1_000** |      **54.238 ns** |     **0.1434 ns** |     **0.1271 ns** |      **54.253 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace8_1 |  text1_000 |     312.082 ns |     1.0210 ns |     0.9551 ns |     312.152 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace8_1** |  **text5_000** |     **226.032 ns** |     **0.6702 ns** |     **0.6269 ns** |     **226.120 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |        replace8_1 |  text5_000 |   1,395.117 ns |     6.1551 ns |     5.7575 ns |   1,394.999 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |        **replace8_1** | **text10_000** |   **1,641.200 ns** |     **4.1853 ns** |     **3.7102 ns** |   **1,640.649 ns** |  **4.2362** |       **-** |       **-** |   **20000 B** |
| RegexrReplace |      replace21_1 |        replace8_1 | text10_000 |   4,414.157 ns |     4.9935 ns |     4.4266 ns |   4,414.344 ns |  4.2343 |       - |       - |   20000 B |
| **StringReplace** |      **replace21_1** |        **replace8_1** | **text50_000** |  **33,468.197 ns** |   **246.2673 ns** |   **230.3586 ns** |  **33,452.661 ns** | **31.1890** | **31.1890** | **31.1890** |   **99955 B** |
| RegexrReplace |      replace21_1 |        replace8_1 | text50_000 |  48,584.144 ns |   144.2169 ns |   134.9006 ns |  48,611.774 ns | 31.1890 | 31.1890 | 31.1890 |   99965 B |
| **StringReplace** |      **replace21_1** |       **replace13_1** |     **text10** |       **7.858 ns** |     **0.0238 ns** |     **0.0223 ns** |       **7.854 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |       replace13_1 |     text10 |      53.712 ns |     0.2512 ns |     0.2350 ns |      53.746 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |       **replace13_1** |     **text50** |      **14.525 ns** |     **0.0195 ns** |     **0.0163 ns** |      **14.531 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |       replace13_1 |     text50 |      58.566 ns |     0.2112 ns |     0.1872 ns |      58.534 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |       **replace13_1** |    **text100** |      **16.990 ns** |     **0.0420 ns** |     **0.0372 ns** |      **16.994 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |       replace13_1 |    text100 |      65.630 ns |     0.2225 ns |     0.2082 ns |      65.552 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |       **replace13_1** |    **text500** |      **30.647 ns** |     **0.1016 ns** |     **0.0950 ns** |      **30.576 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |       replace13_1 |    text500 |     164.559 ns |     0.6381 ns |     0.5329 ns |     164.463 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |       **replace13_1** |  **text1_000** |      **53.663 ns** |     **0.1333 ns** |     **0.1113 ns** |      **53.675 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |       replace13_1 |  text1_000 |     307.929 ns |     1.0663 ns |     0.9974 ns |     307.880 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |       **replace13_1** |  **text5_000** |     **217.742 ns** |     **1.3640 ns** |     **1.2092 ns** |     **217.998 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |       replace13_1 |  text5_000 |   1,398.629 ns |     5.3625 ns |     5.0161 ns |   1,397.801 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |       **replace13_1** | **text10_000** |   **1,623.701 ns** |    **30.5289 ns** |    **28.5568 ns** |   **1,642.745 ns** |  **4.2362** |       **-** |       **-** |   **20008 B** |
| RegexrReplace |      replace21_1 |       replace13_1 | text10_000 |   4,440.827 ns |    29.7287 ns |    27.8082 ns |   4,445.264 ns |  4.2343 |       - |       - |   20008 B |
| **StringReplace** |      **replace21_1** |       **replace13_1** | **text50_000** |  **33,236.828 ns** |   **217.5397 ns** |   **203.4868 ns** |  **33,251.398 ns** | **31.1890** | **31.1890** | **31.1890** |   **99987 B** |
| RegexrReplace |      replace21_1 |       replace13_1 | text50_000 |  48,729.793 ns |   128.3860 ns |   113.8108 ns |  48,705.444 ns | 31.1890 | 31.1890 | 31.1890 |   99997 B |
| **StringReplace** |      **replace21_1** |       **replace21_1** |     **text10** |       **7.854 ns** |     **0.0218 ns** |     **0.0170 ns** |       **7.861 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |       replace21_1 |     text10 |      49.335 ns |     0.2004 ns |     0.1875 ns |      49.307 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |       **replace21_1** |     **text50** |      **14.532 ns** |     **0.0398 ns** |     **0.0373 ns** |      **14.536 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |       replace21_1 |     text50 |      56.225 ns |     0.1374 ns |     0.1285 ns |      56.205 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |       **replace21_1** |    **text100** |      **17.061 ns** |     **0.0367 ns** |     **0.0344 ns** |      **17.062 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |       replace21_1 |    text100 |      69.376 ns |     0.2692 ns |     0.2518 ns |      69.383 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |       **replace21_1** |    **text500** |      **30.758 ns** |     **0.1263 ns** |     **0.1181 ns** |      **30.730 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |       replace21_1 |    text500 |     170.290 ns |     0.6021 ns |     0.5632 ns |     170.375 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |       **replace21_1** |  **text1_000** |      **53.756 ns** |     **0.2047 ns** |     **0.1815 ns** |      **53.704 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |       replace21_1 |  text1_000 |     306.554 ns |     0.9009 ns |     0.8427 ns |     306.818 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |       **replace21_1** |  **text5_000** |     **226.081 ns** |     **0.4665 ns** |     **0.4364 ns** |     **226.157 ns** |       **-** |       **-** |       **-** |         **-** |
| RegexrReplace |      replace21_1 |       replace21_1 |  text5_000 |   1,394.439 ns |     4.6159 ns |     4.3177 ns |   1,395.608 ns |       - |       - |       - |         - |
| **StringReplace** |      **replace21_1** |       **replace21_1** | **text10_000** |   **1,617.934 ns** |     **6.8010 ns** |     **5.6792 ns** |   **1,619.775 ns** |  **4.2362** |       **-** |       **-** |   **20024 B** |
| RegexrReplace |      replace21_1 |       replace21_1 | text10_000 |   4,405.947 ns |    16.8187 ns |    15.7322 ns |   4,411.903 ns |  4.2343 |       - |       - |   20024 B |
| **StringReplace** |      **replace21_1** |       **replace21_1** | **text50_000** |  **33,467.991 ns** |   **251.6156 ns** |   **235.3613 ns** |  **33,464.935 ns** | **31.1890** | **31.1890** | **31.1890** |  **100035 B** |
| RegexrReplace |      replace21_1 |       replace21_1 | text50_000 |  48,763.966 ns |   186.4573 ns |   174.4123 ns |  48,799.817 ns | 31.1890 | 31.1890 | 31.1890 |  100045 B |
