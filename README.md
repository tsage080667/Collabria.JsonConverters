The JsonConverters are custom converters designed to handle case by case deserialization
of json responses returned by Velera API's. Two of the properties that are returned are
inconsistent. The returnCode property and the Success property. Sometimes the returnCode
is a string type and sometimes it's an integer. Same for the Success property. Sometimes it's
returned as a string and sometimes as a boolean. The purpose of these converters are to
ensure that both these properties are returned consistently in the same form.

We want integers for the returnCode and boolean for the Success property.
