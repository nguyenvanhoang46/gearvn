import React from 'react'
import Category from '../catergory'
import Header from '../Header'
import { useState, useEffect, useContext } from 'react';
import { Cartcontext } from '../../contexts/cart/Context';

const Cart = () => {

    const Globalstate = useContext(Cartcontext);
    const state = Globalstate.state;
    const dispatch = Globalstate.dispatch;
    const total = state.reduce((total, item) => {
        return total + item.price * item.quantity;
    }, 0);


    return (
        <>
            <div className='bg-[#f1f0f1]'>
                <Header />
                <Category />
            </div>
            <div className="container mx-auto mt-10">
                <form>
                    <table className='w-full'>
                        <thead>
                            <tr className='border-t-[1px]'>
                                <th className='py-[20px] border-x-[1px] text-center '>Sản phẩm</th>
                                <th className='py-[20px] border-x-[1px] text-center '>Tên sản phẩm</th>
                                <th className='py-[20px] border-x-[1px] text-center '>Giá tiền</th>
                                <th className='py-[20px] border-x-[1px] text-center '>Số lượng</th>
                                <th className='py-[20px] border-x-[1px] text-center '>Xóa</th>
                            </tr>
                        </thead>
                        <tbody>
                            {state.map((item, index) => {
                                return (
                                    <tr key={index} className='border-t-[1px] border-b-[1px] '>
                                        <td className='py-[20px] border-x-[1px]  '>
                                            <div className="text-center">
                                                <a href=""><img src="//product.hstatic.net/1000026716/product/viper_i1650_50ab78f3dd4d4159b6276c7870e16e18_small.jpg" /></a>
                                            </div>
                                        </td>
                                        <td className='py-[20px] border-x-[1px] text-center '>
                                            <div className=''>{item.name}</div>
                                        </td>
                                        <td className='py-[20px] border-x-[1px] text-center '>
                                            <p>{item.quantity * item.price}</p>
                                        </td>
                                        <td className='flex gap-5 py-[20px] border-x-[1px] justify-center text-center '>
                                            <div className='cursor-pointer'
                                                onClick={() => dispatch({ type: "INCREASE", payload: item })}>
                                                +
                                            </div>
                                            <p>{item.quantity}</p>
                                            <div className='cursor-pointer'
                                                onClick={() => {
                                                    if (item.quantity > 1) {
                                                        dispatch({ type: "DECREASE", payload: item });
                                                    } else {
                                                        dispatch({ type: "REMOVE", payload: item })
                                                    }
                                                }}>
                                                -
                                            </div>
                                        </td>
                                        <td className='py-[20px] border-x-[1px] text-center '>
                                            <div className='cursor-pointer' onClick={() => dispatch({ type: "REMOVE", payload: item })}>Xóa</div>
                                        </td>
                                    </tr>
                                )
                            })}

                        </tbody>

                    </table>
                    <div className="grid grid-cols-12 gap-4 ">
                        <div className='col-span-8'>ff</div>
                        {state.length > 0 && (
                            <div className="total">
                                <h2>{total}</h2>
                            </div>
                        )}
                    </div>
                </form>
            </div>
        </>
    )
}

export default Cart