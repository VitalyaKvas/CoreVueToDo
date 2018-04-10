import OktaAuth from '@okta/okta-auth-js'

const org = '{{yourOktaOrgUrl}}',
      clientId = '{{appClientId}}',
      redirectUri = 'http://localhost:5000',
      authorizationServer = 'default'

const oktaAuthClient = new OktaAuth({
  url: org,
  issuer: authorizationServer,
  clientId,
  redirectUri
})

export default {
  client: oktaAuthClient
}