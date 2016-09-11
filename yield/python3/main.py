class Main:
    def __init__(self):
        self.counter = 0;

    def work(self, i):
        s = "[{0}]: doing work: {1}".format(self.counter, i)
        self.counter += 1
        return s

    def some_strings(self, length):
        for i in range(length):
            yield self.work(i)

    def run(self):
        print("creating strings")
        strings = self.some_strings(3)
        print("doing first iter")
        for s in strings:
            print(s)
        print("doing second iter")
        for s in strings:
            print(s)
        print("done")

Main().run()
