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
        strings = self.some_strings(10)
        for s in strings:
            print(s)
        for s in strings:
            print(s)

Main().run()
