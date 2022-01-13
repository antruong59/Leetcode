# Definition for singly-linked list.
class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
class Solution:
    def addTwoNumbers(self, l1, l2):
        stringL1 = ''
        stringL2 = ''

        i = len(l1) - 1
        while i >= 0 :
            stringL1 += str(l1[i])
            i -= 1
        
        i = len(l2) - 1
        while i >= 0 :
            stringL2 += str(l2[i])
            i -= 1

        total = int(stringL1) + int(stringL2)

        result = ListNode()
        
        for i in range(len(total)):
            if i == 0:
                result.val = str(total)[0] 
            else:
                result.val.next = str(total)[i]





        print(total)

l1 = [1, 2, 3]
l2 = [1, 2, 3]

x = Solution()
x.addTwoNumbers(l1, l2)


