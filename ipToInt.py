#https://www.codewars.com/kata/52ea928a1ef5cfec800003ee/train/python

def ip_to_int32(ip):
    ipSplit = ip.split(".")
    for i in range(len(ipSplit)):
        ipSplit[i] = str(bin(int(ipSplit[i]))).replace("0b","")
        ipSplit[i] = ("00000000"[len(ipSplit[i]):] + ipSplit[i])
    stringBin = "".join(ipSplit)
    return (int(stringBin, 2))

ip_to_int32("128.32.10.1")
