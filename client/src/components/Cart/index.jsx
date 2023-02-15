import React from 'react'
import Category from '../catergory'
import Header from '../Header'
import { MdOutlineClose } from 'react-icons/md'
import { GrFormNext } from 'react-icons/gr'
import { IoIosArrowRoundBack } from 'react-icons/io'
import { useContext } from 'react';
import { Cartcontext } from '../../contexts/cart/Context';
import { Link, useNavigate } from 'react-router-dom';
import { AuthContext } from '../../contexts/AuthProvider';

const Cart = () => {
    const { auth } = useContext(AuthContext);
    const Globalstate = useContext(Cartcontext);
    const state = Globalstate.state;
    let navigate = useNavigate();
    // console.log("ff", state)
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
            <div className="bg-[#F8F8FC] h-[830px]">
                <div className="container mx-auto">
                    <div className="pt-8 flex">
                        <Link to={'/'} className='flex gap-1 items-center'>
                            <div className="text-[13px] font-normal text-[#82869E] ">Trang chủ</div>
                            <div className="">
                                <GrFormNext size={18} className="text-[#82869E]" />
                            </div>
                        </Link>
                        <div className='text-[13px] font-normal text-[#82869E] '>Giỏ hàng</div>
                    </div>
                    {state.length <= 0 ?
                        <div className="bg-[#FFFFFF] mt-8 rounded-[8px] text-center py-8 flex justify-center">
                            <div className="">
                                <div className="">
                                    <img src="https://i.imgur.com/Drj57qu.png" className='' />
                                </div>
                                <div className="mt-4 text-[#848788] text-[14px] ">Giỏ hàng chưa có sản phẩm nào</div>
                                <button className='bg-[#1230B0] px-[1.25rem] h-[2.5rem] rounded-[0.25rem] text-[13px] text-white mt-8 '>
                                    <Link to={'/'}>Mua sắm ngay</Link>
                                </button>
                            </div>
                        </div>
                        :
                        <>
                            <div className="mt-10 text-[23px] leading-[32px] font-bold ">Giỏ hàng</div>
                            <div className="rounded-[1rem] gap-6 grid grid-cols-12">
                                <div className="mt-[15px] col-span-8 rounded-[8px] py-[4vh] px-[5vh] bg-[#FFFFFF]  ">
                                    <div className="border-b-[1px] ">
                                        {state.map((item, index) => {
                                            return (
                                                <div key={item.id} className="grid grid-cols-5 text-center border-t-[1px] border-[#dee2e6] items-center">
                                                    <div className="flex justify-center  ">
                                                        <img className=" h-[80px] max-h-[80px]" src={item.images.length > 0 ? item.images[0].url : ""} />
                                                    </div>
                                                    <div className="">
                                                        <div className='text-[13px] '>{item.name}</div>
                                                    </div>
                                                    <div className="flex gap-5 justify-center ">
                                                        <div className='cursor-pointer hover:text-[red] text-[18px] '
                                                            onClick={() => dispatch({ type: "INCREASE", payload: item })}>
                                                            +
                                                        </div>
                                                        <p className='border-[1px] border-[#dee2e6] px-[1vh] text-[16px] '>{item.quantity}</p>
                                                        <div className='cursor-pointer hover:text-[red] text-[18px]'
                                                            onClick={() => {
                                                                if (item.quantity > 1) {
                                                                    dispatch({ type: "DECREASE", payload: item });
                                                                }
                                                            }}>
                                                            -
                                                        </div>
                                                    </div>
                                                    <div className="">
                                                        <p>{(item.quantity * item.price).toLocaleString('vi', { style: 'currency', currency: 'VND' })}</p>
                                                    </div>
                                                    <div className="flex justify-center">
                                                        <div className='cursor-pointer hover:text-[red]' onClick={() => dispatch({ type: "REMOVE", payload: item })}> <MdOutlineClose /></div>
                                                    </div>
                                                </div>
                                            )
                                        })}
                                    </div>
                                </div>
                                <div className="col-span-4 mt-[15px]">
                                    <div className="bg-[#FFFFFF] rounded-[8px] ">
                                        <div className="p-[1rem]">
                                            <h6 className='font-bold'>Thanh toán</h6>
                                            <div className="grid grid-cols-2 mt-2">
                                                <div className="">Số lượng</div>
                                                <div className="text-right">
                                                    {state.length}
                                                </div>
                                            </div>
                                            <div className="grid grid-cols-2 mt-2">
                                                <div className="">Tổng tạm tính</div>
                                                <div className="text-right">
                                                    {state.length > 0 && (
                                                        <div className="total">
                                                            <h2>{(total).toLocaleString('vi', { style: 'currency', currency: 'VND' })}</h2>
                                                        </div>
                                                    )}
                                                </div>
                                            </div>
                                            <div className="grid grid-cols-2 mt-2">
                                                <div className="">Thành tiền</div>
                                                <div className="text-right">
                                                    <div className="text-[#1435C3] font-bold ">
                                                        {state.length > 0 && (
                                                            <div className="total">
                                                                <h2>{(total).toLocaleString('vi', { style: 'currency', currency: 'VND' })}</h2>
                                                            </div>
                                                        )}
                                                    </div>
                                                    <div className='text-[#82869E] text-[12px] font-medium leading-[16px] '>(Đã bao gồm VAT)</div>
                                                </div>
                                            </div>
                                            <div className="mt-7">
                                                <Link className='w-full' to={'/payproduct'}>
                                                    <button className='py-[0.4rem] px-[1rem] text-[#FFFFFF] bg-[#ff391e] w-full hover:opacity-[0.7] '>
                                                        THANH TOÁN
                                                    </button>
                                                </Link>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <Link className='flex items-center gap-2 mt-6 hover:opacity-[0.7] ' to={'/'}>
                                <IoIosArrowRoundBack size={25} />
                                <div className="text-[#6c757d]">Back to Shop</div>
                            </Link>
                        </>
                    }

                </div>
            </div>

        </>
    )
}
export default Cart