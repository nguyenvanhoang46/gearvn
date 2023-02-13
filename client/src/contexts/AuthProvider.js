import { createContext, useState, useEffect } from "react";
import { useQuery } from "react-query";
import { getMeApi } from "../app/services/authService";

export const AuthContext = createContext();

const AuthProvider = ({ children }) => {
    const [auth, setAuth] = useState(null);
    const { refetch } = useQuery(['GET_ME_API'], getMeApi, {
        onSuccess: (data) => {
            setAuth(data)
        }
    });

    const getMeForce = async () => {
        await refetch()
    }

    const clearAuth = () => {
        setAuth(null)
    }

    return <AuthContext.Provider value={{ auth, getMeForce, clearAuth }}>
        {children}
    </AuthContext.Provider>
}

export default AuthProvider;