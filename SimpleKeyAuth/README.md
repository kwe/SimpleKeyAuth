# Simple API Key in header
Authentication based on a simple API key sent in a header.
As basic as it gets!

To test it works use Postman or..

```bash
curl --location --request GET 'http://localhost:5066/' \
--header 'simplekey: letmein'
```