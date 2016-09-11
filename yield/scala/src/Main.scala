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

  def main(args: Array[String]) {
    println("creating strings")
    val strings = someStrings(3)
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
