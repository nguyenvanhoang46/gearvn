import { createContext, useEffect, useReducer } from "react";

export const Cartcontext = createContext();

export const Context = (props) => {




    const reducer = (state, action) => {
        switch (action.type) {
            case 'LOAD_CART':
                return [...action.payload];
            case 'ADD':
                const tempstate = state.filter((item) => action.payload.id === item.id)
                if (tempstate.length > 0) {
                    return state
                } else {
                    const newCart = [...state, action.payload];
                    localStorage.setItem('cart', JSON.stringify(newCart))
                    return newCart;
                }
            case 'INCREASE':
                const tempstate1 = state.map((item) => {
                    if (item.id === action.payload.id) {
                        return { ...item, quantity: item.quantity + 1 };
                    } else {
                        return item
                    }
                });
                localStorage.setItem('cart', JSON.stringify(tempstate1))
                return tempstate1;
            case 'DECREASE':
                const tempstate2 = state.map((item) => {
                    if (item.id === action.payload.id) {
                        return { ...item, quantity: item.quantity - 1 };
                    } else {
                        return item
                    }
                });
                localStorage.setItem('cart', JSON.stringify(tempstate2))
                return tempstate2;
            case 'REMOVE':
                const tempstate3 = state.filter((item) => item.id !== action.payload.id);
                localStorage.setItem('cart', JSON.stringify(tempstate3))
                return tempstate3
            default:
                return state;
        }
    }

    const [state, dispatch] = useReducer(reducer, []);

    useEffect(() => {
        const cart = localStorage.getItem('cart') ? JSON.parse(localStorage.getItem('cart')) : []
        dispatch({type: 'LOAD_CART', payload: cart})

        return () => {

        }
    }, [])

    const info = { state, dispatch };
    return <Cartcontext.Provider value={info}>
        {props.children}
    </Cartcontext.Provider>
}