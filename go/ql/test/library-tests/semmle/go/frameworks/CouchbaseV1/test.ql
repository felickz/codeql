import go
import semmle.go.dataflow.ExternalFlow
import ModelValidation
import utils.test.InlineExpectationsTest
import semmle.go.security.SqlInjection

module SqlInjectionTest implements TestSig {
  string getARelevantTag() { result = "sqlinjection" }

  predicate hasActualResult(Location location, string element, string tag, string value) {
    tag = "sqlinjection" and
    exists(DataFlow::Node sink | SqlInjection::Flow::flowTo(sink) |
      element = sink.toString() and
      value = sink.toString() and
      sink.getLocation() = location
    )
  }
}

import MakeTest<SqlInjectionTest>
