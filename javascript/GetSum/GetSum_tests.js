Test.describe("Basic Tests:", function(){
  Test.assertEquals(GetSum(1, 0), 1);
  Test.assertEquals(GetSum(1, 2), 3);
  Test.assertEquals(GetSum(0, 1), 1);
  Test.assertEquals(GetSum(1, 1), 1);
  Test.assertEquals(GetSum(-1, 0), -1);
  Test.assertEquals(GetSum(-1, 2), 2); 
});
