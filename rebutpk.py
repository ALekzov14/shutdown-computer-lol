import os
import random

pistolet = [1,0,0,0,0,0,0,0,0,0]
if random.choice(pistolet) == 1:
    print("ББ")
    os.system("shutdown -s -t 0")
else:
    print("Пронесло")