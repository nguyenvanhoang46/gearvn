import React, { useState } from 'react'
import Category from '../catergory'
import Header from '../Header'
import { BsFillCartFill } from 'react-icons/bs'
import { AiOutlineLoading } from 'react-icons/ai'
import { GrFormNext } from 'react-icons/gr'
import { AuthContext } from '../../contexts/AuthProvider';
import { Link, useNavigate } from 'react-router-dom';
import { useContext } from 'react';
import { Cartcontext } from '../../contexts/cart/Context';
import { createOrderApi } from '../../app/services/orderService'
import { number } from 'yup'
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';
import swal from 'sweetalert';

const PayProduct = () => {
    const { auth, clearAuth } = useContext(AuthContext);
 
    const navigate = useNavigate();

    const [address, setAddress] = useState("");
    const [fullName, setFullName] = useState();
    const [phone, setPhone] = useState();
    const [email, setEmail] = useState();
    const [city, setCity] = useState("");

    const Globalstate = useContext(Cartcontext);
    const state = Globalstate.state;
    console.log("da", state);
    const total = state.reduce((total, item) => {
        return total + item.price * item.quantity;
    }, 0);

    const handleOrder = async (e) => {
        e.preventDefault();
        try {
            const orderItems = state.map((product) => {
                return {
                    productId: product.id,
                    quantity: product.quantity
                }
            })
            const response = await createOrderApi({ address, fullName, phone, email, city, userId: auth.id, orderItems });
            swal({
                title: "Mua hàng thành công",
                icon: "success",
            });
            Globalstate.dispatch({ type: 'PAY' })
            navigate("/")
        } catch (error) {
            console.log(error.message);
        }
    }

    return (
        <>
            <div className='bg-[#f1f0f1]'>
                <Header />
                <Category />
            </div>
            <div className="bg-[#F8F8FC] h-[830px]">

                <div className="container mx-auto">
                    <div className="pt-8 flex">
                        <Link to={'/cart'} className='flex gap-1 items-center'>
                            <div className="text-[13px] font-normal text-[#82869E] text-[#338dbc] ">Giỏ hàng</div>
                            <div className="">
                                <GrFormNext size={18} className="text-[#82869E]" />
                            </div>
                        </Link>
                        <div className='text-[13px] font-normal text-[#82869E] '>Thông tin giao hàng</div>
                    </div>
                    <form onSubmit={handleOrder} action="">
                        <div className="rounded-[1rem] gap-6 grid grid-cols-12">
                            <div className="mt-[15px] col-span-8 rounded-[8px]">
                                <h2 className='text-[18px] font-medium'>Thông tin thanh toán</h2>
                                <div className="bg-[#FFFFFF] mt-4  py-[4vh] px-[5vh] ">
                                    <div className="w-full mb-5">
                                        <div className="relative">
                                            <label className="absolute font-normal text-[#999999] text-[14px] px-[0.93333em] " for="billing_address_full_name">Họ và tên</label>
                                            <input value={auth.fullName} onChange={(e) => setFullName(e.target.value)} className="border-[1px] outline-[#338dbc] outline-[1px] border-[#d9d9d9] text-[15px] pt-[16px] pb-[3px] text-[#333333] rounded-[4px] pr-[2.8em] pl-[0.8em] w-full bg-white  " />
                                        </div>
                                    </div>
                                    <div className="w-full mb-5">
                                        <div className="relative">
                                            <label className="absolute font-normal text-[#999999] text-[14px] px-[0.93333em] " for="billing_address_full_name">Số điện thoại</label>
                                            <input value={auth.phone} onChange={(e) => setPhone(e.target.value)} className="border-[1px] outline-[#338dbc] border-[#d9d9d9] text-[15px] pt-[16px] pb-[3px] text-[#333333] rounded-[4px] pr-[2.8em] pl-[0.8em] w-full bg-white  " />
                                        </div>
                                    </div>
                                    <div className="w-full mb-5">
                                        <div className="relative">
                                            <label className="absolute font-normal text-[#999999] text-[14px] px-[0.93333em] " for="billing_address_full_name">Email</label>
                                            <input value={auth.email} onChange={(e) => setEmail(e.target.value)} className="border-[1px] outline-[#338dbc] border-[#d9d9d9] text-[15px] pt-[16px] pb-[3px] text-[#333333] rounded-[4px] pr-[2.8em] pl-[0.8em] w-full bg-white  " />
                                        </div>
                                    </div>
                                    <div className="w-full mb-5">
                                        <div className="relative">
                                            <label className="absolute font-normal text-[#999999] text-[14px] px-[0.93333em] " for="billing_address_full_name">Địa chỉ</label>
                                            <input value={address} onChange={(e) => setAddress(e.target.value)} className="border-[1px] outline-[#338dbc] border-[#d9d9d9] text-[15px] pt-[16px] pb-[3px] text-[#333333] rounded-[4px] pr-[2.8em] pl-[0.8em] w-full bg-white  " />
                                        </div>
                                    </div>
                                    <div className="w-full mb-5">
                                        <div className="relative">
                                            <label className="absolute font-normal text-[#999999] text-[14px] px-[0.93333em] " for="billing_address_full_name">Thành phố</label>
                                            <input value={city} onChange={(e) => setCity(e.target.value)} className="border-[1px] outline-[#338dbc] border-[#d9d9d9] text-[15px] pt-[16px] pb-[3px] text-[#333333] rounded-[4px] pr-[2.8em] pl-[0.8em] w-full bg-white  " />
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div className="col-span-4 mt-[15px]">
                                <h2 className='text-[18px] font-medium'>Đơn hàng của bạn</h2>
                                <div className="bg-[#FFFFFF] rounded-[8px] pt-[5px] pr-[20px] pb-[15px] pl-[20px] mt-3 ">
                                    <div className=''>
                                        <div className='mt-2 flex justify-between' >
                                            <h4><b>Cart</b></h4>
                                            <span className="flex items-center gap-1"><BsFillCartFill /><b>{state.length}</b></span>
                                        </div>
                                        <table className='w-full mt-3'>
                                            <thead className=''>
                                                <tr className='text-left mt-3 border-b-[1px] '>
                                                    <th className=''>Tên sản phẩm</th>
                                                    <th className='pl-2'>Số lượng</th>
                                                    <th className='text-right'>Giá</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                {state.map((item, index) => {
                                                    return (
                                                        <tr className='text-left border-t-[1px]  '>
                                                            <td className='text-[14px] w-[50%]  '>{item.name}</td>
                                                            <td className='pl-9 text-[15px] '>{item.quantity}</td>
                                                            <td className='text-right text-[15px]'>{(item.quantity * item.price).toLocaleString('vi', { style: 'currency', currency: 'VND' })}</td>
                                                        </tr>
                                                    )
                                                })}
                                            </tbody>
                                        </table>
                                        <hr className='mt-10' />
                                        <p className='flex justify-between mt-5'>
                                            Tổng
                                            <span className=''><b>{(total).toLocaleString('vi', { style: 'currency', currency: 'VND' })}</b></span>
                                        </p>
                                    </div>
                                </div>
                                <div className="mt-7">
                                    <button type='submit' className="py-[0.4rem] px-[1rem] text-[#FFFFFF] bg-[#ff391e] w-full hover:opacity-[0.7] uppercase ">Đặt hàng</button>
                                </div>
                            </div>
                        </div>
                    </form>

                </div>
            </div>
        </>
    )
}

export default PayProduct