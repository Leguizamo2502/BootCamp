using Entity.Domain.Models.Implements;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Infrastructure.DataInit
{
    public class CardSeeder : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasData(
  
                new Card { Id = 1, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/1.png", Health = 186, Force = 155, Resistance = 113, Magic = 163, Defense = 134, Speed = 64 },
                new Card { Id = 2, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/2.png", Health = 52, Force = 95, Resistance = 176, Magic = 69, Defense = 90, Speed = 168 },
                new Card { Id = 3, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/3.png", Health = 95, Force = 98, Resistance = 63, Magic = 199, Defense = 160, Speed = 133 },
                new Card { Id = 4, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/4.png", Health = 133, Force = 123, Resistance = 115, Magic = 65, Defense = 132, Speed = 58 },
                new Card { Id = 5, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/5.png", Health = 71, Force = 153, Resistance = 112, Magic = 59, Defense = 63, Speed = 183 },
                new Card { Id = 6, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/6.png", Health = 76, Force = 193, Resistance = 117, Magic = 140, Defense = 69, Speed = 154 },
                new Card { Id = 7, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/7.png", Health = 179, Force = 76, Resistance = 70, Magic = 166, Defense = 120, Speed = 88 },
                new Card { Id = 8, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/8.png", Health = 100, Force = 73, Resistance = 58, Magic = 68, Defense = 121, Speed = 184 },
                new Card { Id = 9, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/9.png", Health = 196, Force = 184, Resistance = 93, Magic = 64, Defense = 140, Speed = 96 },
                new Card { Id = 10, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/10.png", Health = 149, Force = 177, Resistance = 72, Magic = 146, Defense = 99, Speed = 106 },
                new Card { Id = 11, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/11.png", Health = 54, Force = 70, Resistance = 126, Magic = 52, Defense = 64, Speed = 76 },
                new Card { Id = 12, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/12.png", Health = 86, Force = 107, Resistance = 77, Magic = 197, Defense = 111, Speed = 146 },
                new Card { Id = 13, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/13.png", Health = 59, Force = 136, Resistance = 183, Magic = 61, Defense = 122, Speed = 60 },
                new Card { Id = 14, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/14.png", Health = 124, Force = 180, Resistance = 162, Magic = 75, Defense = 81, Speed = 109 },
                new Card { Id = 15, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/15.png", Health = 190, Force = 147, Resistance = 81, Magic = 126, Defense = 57, Speed = 130 },
                new Card { Id = 16, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/16.png", Health = 64, Force = 100, Resistance = 121, Magic = 90, Defense = 73, Speed = 67 },
                new Card { Id = 17, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/17.png", Health = 84, Force = 62, Resistance = 124, Magic = 79, Defense = 194, Speed = 87 },
                new Card { Id = 18, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/18.png", Health = 70, Force = 174, Resistance = 172, Magic = 116, Defense = 169, Speed = 69 },
                new Card { Id = 19, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/19.png", Health = 80, Force = 163, Resistance = 178, Magic = 179, Defense = 95, Speed = 178 },
                new Card { Id = 20, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/20.png", Health = 108, Force = 93, Resistance = 90, Magic = 128, Defense = 162, Speed = 108 },
                new Card { Id = 21, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/21.png", Health = 199, Force = 57, Resistance = 177, Magic = 148, Defense = 125, Speed = 102 },
                new Card { Id = 22, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/22.png", Health = 66, Force = 165, Resistance = 97, Magic = 156, Defense = 175, Speed = 124 },
                new Card { Id = 23, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/23.png", Health = 98, Force = 168, Resistance = 170, Magic = 122, Defense = 97, Speed = 169 },
                new Card { Id = 24, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/24.png", Health = 182, Force = 117, Resistance = 54, Magic = 129, Defense = 187, Speed = 171 },
                new Card { Id = 25, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/25.png", Health = 61, Force = 199, Resistance = 111, Magic = 67, Defense = 191, Speed = 135 },
                new Card { Id = 26, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/26.png", Health = 159, Force = 169, Resistance = 52, Magic = 87, Defense = 65, Speed = 195 },
                new Card { Id = 27, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/27.png", Health = 173, Force = 134, Resistance = 158, Magic = 111, Defense = 158, Speed = 134 },
                new Card { Id = 28, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/28.png", Health = 188, Force = 84, Resistance = 146, Magic = 125, Defense = 156, Speed = 51 },
                new Card { Id = 29, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/29.png", Health = 53, Force = 185, Resistance = 56, Magic = 164, Defense = 76, Speed = 187 },
                new Card { Id = 30, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/30.png", Health = 83, Force = 87, Resistance = 174, Magic = 55, Defense = 186, Speed = 114 },
                new Card { Id = 31, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/31.png", Health = 129, Force = 80, Resistance = 182, Magic = 188, Defense = 148, Speed = 175 },
                new Card { Id = 32, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/32.png", Health = 104, Force = 182, Resistance = 53, Magic = 105, Defense = 107, Speed = 198 },
                new Card { Id = 33, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/33.png", Health = 74, Force = 157, Resistance = 175, Magic = 84, Defense = 166, Speed = 80 },
                new Card { Id = 34, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/34.png", Health = 143, Force = 161, Resistance = 118, Magic = 96, Defense = 174, Speed = 200 },
                new Card { Id = 35, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/35.png", Health = 165, Force = 192, Resistance = 148, Magic = 57, Defense = 67, Speed = 71 },
                new Card { Id = 36, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/36.png", Health = 150, Force = 124, Resistance = 133, Magic = 173, Defense = 188, Speed = 107 },
                new Card { Id = 37, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/37.png", Health = 177, Force = 140, Resistance = 130, Magic = 143, Defense = 172, Speed = 197 },
                new Card { Id = 38, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/38.png", Health = 198, Force = 127, Resistance = 159, Magic = 196, Defense = 193, Speed = 173 },
                new Card { Id = 39, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/39.png", Health = 69, Force = 59, Resistance = 163, Magic = 103, Defense = 79, Speed = 180 },
                new Card { Id = 40, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/40.png", Health = 174, Force = 104, Resistance = 150, Magic = 110, Defense = 131, Speed = 132 },
                new Card { Id = 41, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/41.png", Health = 127, Force = 108, Resistance = 149, Magic = 62, Defense = 102, Speed = 125 },
                new Card { Id = 42, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/42.png", Health = 72, Force = 128, Resistance = 59, Magic = 108, Defense = 51, Speed = 159 },
                new Card { Id = 43, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/43.png", Health = 114, Force = 111, Resistance = 194, Magic = 93, Defense = 112, Speed = 66 },
                new Card { Id = 44, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/44.png", Health = 131, Force = 94, Resistance = 152, Magic = 177, Defense = 71, Speed = 112 },
                new Card { Id = 45, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/45.png", Health = 88, Force = 53, Resistance = 138, Magic = 50, Defense = 127, Speed = 95 },
                new Card { Id = 46, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/46.png", Health = 154, Force = 170, Resistance = 125, Magic = 184, Defense = 137, Speed = 86 },
                new Card { Id = 47, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/47.png", Health = 168, Force = 164, Resistance = 114, Magic = 70, Defense = 52, Speed = 103 },
                new Card { Id = 48, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/48.png", Health = 62, Force = 109, Resistance = 191, Magic = 114, Defense = 159, Speed = 79 },
                new Card { Id = 49, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/49.png", Health = 178, Force = 71, Resistance = 195, Magic = 77, Defense = 105, Speed = 61 },
                new Card { Id = 50, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/50.png", Health = 170, Force = 130, Resistance = 168, Magic = 134, Defense = 55, Speed = 72 },
                new Card { Id = 51, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/51.png", Health = 117, Force = 175, Resistance = 139, Magic = 157, Defense = 185, Speed = 55 },
                new Card { Id = 52, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/52.png", Health = 191, Force = 138, Resistance = 153, Magic = 94, Defense = 116, Speed = 57 },
                new Card { Id = 53, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/53.png", Health = 65, Force = 116, Resistance = 87, Magic = 85, Defense = 139, Speed = 105 },
                new Card { Id = 54, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/54.png", Health = 169, Force = 181, Resistance = 109, Magic = 112, Defense = 181, Speed = 199 },
                new Card { Id = 55, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/55.png", Health = 82, Force = 99, Resistance = 55, Magic = 101, Defense = 66, Speed = 145 },
                new Card { Id = 56, ImageUrl = "https://raw.githubusercontent.com/Leguizamo2502/ImageBootcamp/refs/heads/main/images/56.png", Health = 55, Force = 151, Resistance = 67, Magic = 155, Defense = 80, Speed = 182 }


            );
        }
    }
}
