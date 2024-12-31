namespace LoginFlowMAUI.Services
{
    public class AuthService
    {
        private const string AuthStateKey = "AuthState";
        public async Task<bool> IsAuthenticatedAsync()
        {
            await Task.Delay(2000);

            var authState = Preferences.Default.Get<bool>(key: AuthStateKey,defaultValue: false);

            return authState;
        }
        public void Login()
        {
            Preferences.Default.Set<bool>(key: AuthStateKey,value: true);
        }
        public void Logout() 
        {
            Preferences.Default.Remove(key: AuthStateKey);
        }
    }
}