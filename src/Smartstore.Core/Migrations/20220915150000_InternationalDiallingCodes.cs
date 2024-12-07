﻿using FluentMigrator;
using Smartstore.Core.Common;
using Smartstore.Data.Migrations;

namespace Smartstore.Core.Data.Migrations
{
    [MigrationVersion("2022-09-15 15:00:00", "Core: InternationalDiallingCodes")]
    internal class InternationalDiallingCodes : Migration, IDataSeeder<SmartDbContext>
    {
        public override void Up()
        {
            var propTableName = nameof(Country);
            Create.Column(nameof(Country.DiallingCode)).OnTable(propTableName).AsInt32().Nullable();
        }

        public override void Down()
        {
        }

        public bool RollbackOnFailure => false;

        public async Task SeedAsync(SmartDbContext context, CancellationToken cancelToken = default)
        {
            var diallingCodes = new Dictionary<string, int>
            {
                { "AUT", 43 },
                { "LBN", 961 },
                { "LSO", 266 },
                { "LBR", 231 },
                { "LBY", 218 },
                { "LIE", 423 },
                { "LTU", 370 },
                { "LUX", 352 },
                { "MAC", 853 },
                { "MKD", 389 },
                { "MDG", 261 },
                { "MWI", 265 },
                { "MDV", 960 },
                { "MLI", 223 },
                { "MLT", 356 },
                { "MHL", 692 },
                { "MTQ", 596 },
                { "MRT", 222 },
                { "MUS", 230 },
                { "MYT", 262 },
                { "FSM", 691 },
                { "MDA", 373 },
                { "MCO", 377 },
                { "MNG", 976 },
                { "MNE", 382 },
                { "MSR", 1 },
                { "LVA", 371 },
                { "LAO", 856 },
                { "KGZ", 996 },
                { "KOR", 82 },
                { "EST", 372 },
                { "ETH", 251 },
                { "FLK", 500 },
                { "FRO", 298 },
                { "FJI", 679 },
                { "GUF", 594 },
                { "PYF", 689 },
                { "ATF", 262 },
                { "GAB", 241 },
                { "GMB", 220 },
                { "GHA", 233 },
                { "GRL", 299 },
                { "MAR", 212 },
                { "GRD", 1 },
                { "GUM", 1 },
                { "GIN", 224 },
                { "GNB", 245 },
                { "GUY", 592 },
                { "HTI", 509 },
                { "HMD", 672 },
                { "HND", 504 },
                { "ISL", 354 },
                { "IRN", 98 },
                { "IRQ", 964 },
                { "KEN", 254 },
                { "KIR", 686 },
                { "GLP", 590 },
                { "MOZ", 258 },
                { "MMR", 95 },
                { "NAM", 264 },
                { "SHN", 290 },
                { "SPM", 508 },
                { "SDN", 249 },
                { "SUR", 597 },
                { "SJM", 47 },
                { "SWZ", 268 },
                { "SYR", 963 },
                { "TJK", 992 },
                { "TZA", 255 },
                { "TGO", 228 },
                { "TKL", 690 },
                { "TON", 676 },
                { "LKA", 94 },
                { "TTO", 1 },
                { "TKM", 993 },
                { "TCA", 1 },
                { "TUV", 688 },
                { "UGA", 256 },
                { "VUT", 678 },
                { "VAT", 379 },
                { "VNM", 84 },
                { "VGB", 1 },
                { "VIR", 1 },
                { "WLF", 681 },
                { "ESH", 212 },
                { "YEM", 967 },
                { "TUN", 216 },
                { "ERI", 291 },
                { "SGS", 500 },
                { "SLB", 677 },
                { "NRU", 674 },
                { "NPL", 977 },
                { "ANT", 599 },
                { "NCL", 687 },
                { "NIC", 505 },
                { "NER", 227 },
                { "NGA", 234 },
                { "NIU", 683 },
                { "NFK", 672 },
                { "MNP", 1 },
                { "OMN", 968 },
                { "PLW", 680 },
                { "SOM", 252 },
                { "PAN", 507 },
                { "PCN", 64 },
                { "REU", 262 },
                { "RWA", 250 },
                { "KNA", 1 },
                { "LCA", 1 },
                { "VCT", 1 },
                { "WSM", 685 },
                { "SMR", 378 },
                { "STP", 239 },
                { "SEN", 221 },
                { "SYC", 248 },
                { "SLE", 232 },
                { "PNG", 675 },
                { "ZMB", 260 },
                { "GNQ", 240 },
                { "DMA", 1 },
                { "ECU", 593 },
                { "EGY", 20 },
                { "FIN", 358 },
                { "FRA", 33 },
                { "GEO", 995 },
                { "GIB", 350 },
                { "GRC", 30 },
                { "GTM", 502 },
                { "HKG", 852 },
                { "HUN", 36 },
                { "IND", 91 },
                { "IDN", 62 },
                { "IRL", 353 },
                { "ISR", 972 },
                { "ITA", 39 },
                { "JAM", 1 },
                { "JPN", 81 },
                { "JOR", 962 },
                { "KAZ", 7 },
                { "PRK", 351 },
                { "KWT", 956 },
                { "MYS", 60 },
                { "MEX", 52 },
                { "NLD", 31 },
                { "NZL", 64 },
                { "DOM", 1 },
                { "DNK", 45 },
                { "CZE", 420 },
                { "CYP", 357 },
                { "DEU", 49 },
                { "CHE", 41 },
                { "USA", 1 },
                { "CAN", 1 },
                { "ARG", 54 },
                { "ARM", 374 },
                { "ABW", 297 },
                { "AUS", 61 },
                { "AZE", 994 },
                { "BHS", 1 },
                { "BGD", 880 },
                { "BLR", 375 },
                { "NOR", 47 },
                { "BEL", 32 },
                { "BMU", 1 },
                { "BOL", 591 },
                { "BIH", 387 },
                { "BRA", 55 },
                { "BGR", 359 },
                { "CYM", 1 },
                { "CHL", 56 },
                { "CHN", 86 },
                { "COL", 57 },
                { "CRI", 506 },
                { "HRV", 685 },
                { "CUB", 53 },
                { "BLZ", 501 },
                { "PAK", 92 },
                { "PRY", 595 },
                { "PER", 51 },
                { "AGO", 244 },
                { "AIA", 1 },
                { "ATA", 672 },
                { "ATG", 1 },
                { "BHR", 973 },
                { "BRB", 1 },
                { "BEN", 229 },
                { "BTN", 975 },
                { "BWA", 267 },
                { "BVT", 55 },
                { "IOT", 246 },
                { "BRN", 673 },
                { "AND", 376 },
                { "BFA", 226 },
                { "KHM", 855 },
                { "CMR", 237 },
                { "CPV", 238 },
                { "CAF", 236 },
                { "TCD", 235 },
                { "CXR", 61 },
                { "CCK", 61 },
                { "COM", 269 },
                { "COG", 242 },
                { "COK", 682 },
                { "CIV", 225 },
                { "DJI", 253 },
                { "BDI", 257 },
                { "SLV", 503 },
                { "ASM", 1 },
                { "ALB", 355 },
                { "PHL", 63 },
                { "POL", 48 },
                { "PRT", 351 },
                { "PRI", 1 },
                { "QAT", 974 },
                { "ROM", 40 },
                { "RUS", 7 },
                { "SAU", 966 },
                { "SGP", 65 },
                { "SVK", 421 },
                { "SVN", 386 },
                { "ZAF", 27 },
                { "DZA", 213 },
                { "ESP", 34 },
                { "TWN", 886 },
                { "THA", 66 },
                { "TUR", 90 },
                { "UKR", 380 },
                { "ARE", 971 },
                { "GBR", 44 },
                { "UMI", 1 },
                { "URY", 598 },
                { "UZB", 998 },
                { "VEN", 58 },
                { "SRB", 381 },
                { "AFG", 93 },
                { "SWE", 46 },
                { "ZWE", 263 }
            };

            var countries = (await context.Countries.Where(x => !string.IsNullOrEmpty(x.ThreeLetterIsoCode)).ToListAsync())
                .ToDictionarySafe(x => x.ThreeLetterIsoCode);

            foreach (var code in diallingCodes)
            {
                if (countries.TryGetValue(code.Key, out var country))
                {
                    country.DiallingCode = code.Value;
                }
            }

            await context.SaveChangesAsync();
        }
    }
}