import React from 'react'
import Category from '../catergory'
import Header from '../Header'
import { Link } from 'react-router-dom'
import Footer from '../Footer'
const ProductDetail = () => {
    return (
        <>
            <div className="">
                <Header />
                <Category />
            </div>

            <div className="container mx-auto grid grid-cols-2">
                <div className="">

                </div>
                <div className=''>
                    <h1 className='py-20px text-[24px] m-0 font-medium  '>Laptop Lenovo V14 G2 ITL 82KA00RRVN</h1>
                    <p className='mt-2'><span >✔&nbsp;Bảo hành chính hãng 12&nbsp;tháng.&nbsp;</span></p>
                    <p className='mt-2'><span>✔ Hỗ trợ đổi mới trong 7 ngày.&nbsp;</span></p>
                    <p className='mt-2'><span>✔ Windows bản quyền tích hợp. .&nbsp;</span></p>
                    <p className='mt-2'><span>✔ Miễn phí giao hàng toàn quốc.</span></p>
                    <hr className='my-[20px] ' />
                    <p><span className='text-[#ff0000] text-[17px] '><u><strong>Quà tặng:</strong></u></span></p>
                    <p className='mt-1'><span className='text-[15px] '><strong>🎁 Túi chống sốc GearVN&nbsp;14"</strong></span></p>
                    <p className='mt-1'><span className='text-[15px] '><strong>🎁 Balo Lenovo Office</strong></span></p>
                    <p className='mt-1'><span className='text-[15px] '><strong>🎁 Chuột Havit MS66GT Black</strong></span></p>
                    <p className='mt-1'><span className='text-[15px] '><strong><a>🎁 Voucher Got It trị giá 200,000đ&nbsp;"SIÊU SALE CUỐI NĂM" (từ 16.12 - 31.12.2022)</a></strong></span></p>
                    <hr className='my-[20px] ' />
                    <p><span className='text-[#ff0000] text-[17px] '><strong><u>ƯU ĐÃI KHI MUA KÈM LAPTOP:</u></strong></span></p>
                    <p>
                        <span className='text-[15px] text-[#428bca] '>

                            ⭐ <Link className='hover:text-[#f45b4f] ' to={"/"}>Mua túi chống sốc chỉ với giá 49.000đ</Link>
                            <br />
                            ⭐ <Link className='hover:text-[#f45b4f] ' to={"/"} >Giảm ngay 100.000đ khi mua kèm Ram Laptop.</Link>
                            <br />
                            ⭐ <Link className='hover:text-[#f45b4f] ' to={"/"} >Giảm đến 200.000đ khi mua kèm Balo, túi chống sốc, phụ kiện.</Link>
                            <br />
                            ⭐ <Link className='hover:text-[#f45b4f] ' to={"/"} >Giảm ngay 30.000đ khi mua Đế tản nhiệt Laptop.</Link>
                            <br />
                            ⭐ Giảm ngay 100.000đ khi mua chuột TUF Gaming M3, Logitech G203, G102.
                        </span>
                    </p>

                    <hr className='my-[20px] ' />
                    <p className='text-[#ff0000] '><strong>Hỗ trợ trả góp MPOS (Thẻ tín dụng), HDSAISON <Link to={"/"}>(<span className='text-[#3498db]'>Xem chi tiết</span>)</Link>.</strong></p>
                    <div className="mt-4">
                        <span className="text-[15px] mr-3 font-medium ">Giá Cũ:</span><span className="text-[#888] text-[20px] "><del>22,990,000₫</del></span>
                        <br />
                        <span className="text-[15px] mr-2 font-medium ">Giá KM:</span><span className="text-[#e61010] text-[20px] font-bold ">18,490,000₫  </span>
                    </div>
                    <div className='mt-3 '>
                        <Link to={"/"} className='bg-[#ed1f24] pt-[3px] pb-[7px] px-[30px] text-[24px] rounded font-bold text-[#fff] '>Đặt hàng</Link>
                    </div>
                </div>
            </div>
            
        </>
    )
}

export default ProductDetail