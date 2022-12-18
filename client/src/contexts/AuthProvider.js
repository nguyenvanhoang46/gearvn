import { createContext, useState, useEffect } from "react";
import { getMeApi } from "../app/services/authService";

export const AuthContext = createContext();

const AuthProvider = ({ children }) => {
    const [auth, setAuth] = useState(null);
    useEffect(() => {
        (async () => {
            const data = await getMeApi();
            setAuth(data)
        })()
    }, []);

    return <AuthContext.Provider value={{auth}}>
        {children}
    </AuthContext.Provider>
}

export default AuthProvider;