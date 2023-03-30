import React from 'react'
import { IoCloseOutline } from 'react-icons/io5'

const ModalOrder = (props) => {
    const { open, onClose, orderView } = props;
    return (
        <>
            {open && (
                <div className="fixed rounded h-auto py-14 w-[30%] px-4 border-[1px] bg-white  z-50 items-center flex top-[20%] left-[40%] shadow-md">
                    <table className='w-full'>
                        <thead>
                            <tr className='border-[1px]'>
                                <th className='border-[1px] w-[]'>
                                    <p>Tên sản phẩm</p>
                                </th>
                                <th className='border-[1px]'>
                                    <p>Giá</p>
                                </th>
                                <th className='border-[1px]'>
                                    <p>Số lượng</p>
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            {orderView.orderItems?.map((item) => {
                                return (
                                    <tr className='border-[1px] text-center' key={item.id}>
                                        <td className='border-[1px] py-3 px-5'>
                                            {item.product.name}
                                        </td>
                                        <td className='border-[1px] py-3 px-5'>
                                            {item.product.price}
                                        </td>
                                        <td className='border-[1px] py-3 px-5'>
                                            {item.product.quantity}
                                        </td>
                                    </tr>
                                )
                            })}
                        </tbody>
                    </table>

                    <button className="absolute right-0 top-0 p-4 " onClick={onClose}>
                        <IoCloseOutline className="text-[23px] opacity-50 " />
                    </button>
                </div>)}
        </>
    )
}

export default ModalOrder