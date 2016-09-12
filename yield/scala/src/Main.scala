object Main {

  private var counter = 0

  def work(i: Int) = {
    val s = s"[${counter}]: doing work: ${i}"
    counter += 1
    s
  }

  def someStrings(length: Int) = {
    for (i <- 0 until length)
      yield work(i)
  }

  def someStringsUsingIterator(length: Int) = {
    for (i <- (0 until length).iterator)
      yield work(i)
  }

  def main(args: Array[String]) {
    val fns = List(someStrings _, someStringsUsingIterator _);
    for (fn <- fns) {
      println("creating strings")
      val strings = fn(3)
      println("doing first iter")
      for (s <- strings) {
        println(s)
      }
      println("doing second iter")
      for (s <- strings) {
        println(s)
      }
      println("done")
    }
  }
}
