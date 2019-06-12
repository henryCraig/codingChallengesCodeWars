#https://www.codewars.com/kata/5262119038c0985a5b00029f/train/python

def is_prime(num):
    if num > 1 or num <-1:
        #print('hello')
        return True
    else:
        return False




print(is_prime(-1))
print(is_prime(0)) #False, '0 is not prime')
print(is_prime(1)) #False, '1 is not prime')
print(is_prime(2)) #True, '2 is prime')
